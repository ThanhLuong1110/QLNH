using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyNH.QLDB;

namespace QuanLyNH
{
    public partial class ucQLBan : UserControl
    {      

        string maBanDangChon = "";
        public ucQLBan()
        {
            InitializeComponent();
        }

        private void ucQLBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM Ban";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                dgvDanhSachBan.DataSource = dt;

                string[] cotCanAn = { "MaBan", "TrangThai", "SoChoNgoi"};

                foreach (string tenCot in cotCanAn)
                {
                    if (dgvDanhSachBan.Columns.Contains(tenCot))
                        dgvDanhSachBan.Columns[tenCot].Visible = false;
                }

               // dgvDanhSachBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void dgvDanhSachBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maBan = dgvDanhSachBan.Rows[e.RowIndex].Cells["colMaBan"].Value.ToString();

                maBanDangChon = maBan;

                try
                {
                  //  if (KetNoi.State != ConnectionState.Open) KetNoi.Open();

                    string query = "SELECT * FROM Ban WHERE MaBan = @MaBan";
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@MaBan", maBan);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblBan.Text = reader["MaBan"].ToString();
                                txtMaBan.Text = reader["MaBan"].ToString();
                                cbxTrangThai.Text = reader["TrangThai"].ToString();
                                nudSoChoNgoi.Value = Convert.ToDecimal(reader["SoChoNgoi"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy thông tin: " + ex.Message);
                }
                finally
                {
                    //if (KetNoi.State == ConnectionState.Open) KetNoi.Close();
                }
            }
        }

        

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBan.Text)) { MessageBox.Show("Vui lòng nhập mã bàn!"); return; }

            try
            {
                using (SqlConnection KetNoi = new SqlConnection())
                {
                    KetNoi.Open();

                    string query = "INSERT INTO Ban (MaBan, SoChoNgoi, TrangThai) VALUES (@MaBan, @SoChoNgoi, @TrangThai)";

                    using (SqlCommand cmd = new SqlCommand(query, KetNoi))
                    {
                        cmd.Parameters.AddWithValue("@MaBan", txtMaBan.Text);
                        cmd.Parameters.AddWithValue("@TrangThai", cbxTrangThai.Text);
                        cmd.Parameters.AddWithValue("@SoChoNgoi", nudSoChoNgoi.Value);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm bàn thành công!");
                        btnLamMoi_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaBan.Clear();
            cbxTrangThai.Text = "";
            nudSoChoNgoi.Value = 0;
            lblBan.Text = "";
            lblTien.Text = "";

            maBanDangChon = "";
            txtMaBan.Focus();
            LoadData();
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maBanDangChon))
            {
                MessageBox.Show("Vui lòng chọn bàn cần sửa trong danh sách!");
                return;
            }

            try
            {
                using (SqlConnection KetNoi = new SqlConnection())
                {
                    KetNoi.Open();
                    string query = "UPDATE Ban SET TrangThai=@TrangThai, SoChoNgoi=@SoChoNgoi WHERE MaBan=@MaBan";

                    using (SqlCommand cmd = new SqlCommand(query, KetNoi))
                    {
                        cmd.Parameters.AddWithValue("@MaBan", maBanDangChon);
                        cmd.Parameters.AddWithValue("@TrangThai", cbxTrangThai.Text);
                        cmd.Parameters.AddWithValue("@SoChoNgoi", nudSoChoNgoi.Value);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        btnLamMoi_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maBanDangChon))
            {
                MessageBox.Show("Vui lòng chọn bàn cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa bàn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection KetNoi = new SqlConnection())
                    {
                        KetNoi.Open();
                        string query = "DELETE FROM Ban WHERE MaBan=@MaBan";

                        using (SqlCommand cmd = new SqlCommand(query, KetNoi))
                        {
                            cmd.Parameters.AddWithValue("@MaBan", maBanDangChon);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Đã xóa bàn!");
                            btnLamMoi_Click(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message + "\n(Có thể bàn này đang dính khóa ngoại với bảng Hóa Đơn/Lương)");
                }
            }
        }

        private void lblTien_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbxDanhSachBan_Click(object sender, EventArgs e)
        {

        }
    }
}
