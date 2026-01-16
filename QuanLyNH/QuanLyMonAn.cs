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
    public partial class QuanLyMonAn : UserControl
    {
        public QuanLyMonAn()
        {
            InitializeComponent();
        }

        private void ResetTextBox()
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtDonGia.Clear();
        }

        private void QuanLyMonAn_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM MonAn";
            dgvMonAn.DataSource = DatabaseHelper.ExecuteQuery(query);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)        
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text) ||
            string.IsNullOrWhiteSpace(txtTenMon.Text) ||
            string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã món, Tên món và Đơn giá.");
                return;
            }


            string query = "INSERT INTO MonAn (MaMon, TenMon, DonGia) VALUES (@MaMon, @TenMon, @DonGia)";
            
            try
            {
                
                int result = DatabaseHelper.ExecuteNonQuery(query,
                new SqlParameter("@MaMon", txtMaMon.Text.Trim()),
                new SqlParameter("@TenMon", txtTenMon.Text.Trim()),
                new SqlParameter("@DonGia", decimal.Parse(txtDonGia.Text.Trim()))
                );

                if (result > 0)
                {
                    MessageBox.Show("Thêm món ăn thành công!");
                    QuanLyMonAn_Load(sender, e); // Gọi lại để cập nhật dgv
                    ResetTextBox();
                }
                else
                {
                    MessageBox.Show("Không thêm được dữ liệu.");
                }
            }
            catch (SqlException ex) when (ex.Message.Contains("PRIMARY KEY"))
            {
                MessageBox.Show($"Mã món đã tồn tại. Vui lòng nhập mã khác.\nMã lỗi SQL: {ex.Number}\nChi tiết: {ex.Message}");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi cơ sở dữ liệu.\nMã lỗi SQL: {ex.Number}\nChi tiết: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text))
            {
                MessageBox.Show("Vui lòng nhập mã món hoặc chọn dòng cần xóa.");
                return;
            }

            string query = "DELETE FROM MonAn WHERE MaMon = @MaMon";

            try
            {

                int result = DatabaseHelper.ExecuteNonQuery(query,
                new SqlParameter("@MaMon", txtMaMon.Text.Trim())
                );

                if (result > 0)
                {
                    MessageBox.Show("Xóa món ăn thành công!");
                    QuanLyMonAn_Load(sender, e); // Gọi lại để cập nhật dgv
                    ResetTextBox();

                }
                else
                {
                    MessageBox.Show("Không tìm thấy món ăn để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text) ||
            string.IsNullOrWhiteSpace(txtTenMon.Text) ||
            string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã món, Tên món và Đơn giá.");
                return;
            }

            string query = "UPDATE MonAn SET TenMon = @TenMon, DonGia = @DonGia WHERE MaMon = @MaMon";

            try
            {
                int result = DatabaseHelper.ExecuteNonQuery(query,
                new SqlParameter("@MaMon", txtMaMon.Text.Trim()),
                new SqlParameter("@TenMon", txtTenMon.Text.Trim()),
                new SqlParameter("@DonGia", decimal.Parse(txtDonGia.Text.Trim()))
                );

                if (result > 0)
                {
                    MessageBox.Show("Sửa món ăn thành công!");
                    QuanLyMonAn_Load(sender, e); // Gọi lại để cập nhật dgv
                    ResetTextBox();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy món ăn để sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtTiemKiem_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM MonAn WHERE MaMon LIKE @TuKhoa OR TenMon LIKE @TuKhoa OR DonGia LIKE @TuKhoa";
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(
                    query,
                    new SqlParameter("@TuKhoa", "%" + txtTimKiem.Text.Trim() + "%")
                );

                if (dt.Rows.Count > 0)
                {
                    dgvMonAn.DataSource = dt; // hiển thị kết quả lên DataGridView
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }
        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMonAn.CurrentRow != null)
            {
                txtMaMon.Text = dgvMonAn.CurrentRow.Cells["colMaMon"].Value.ToString();
                txtTenMon.Text = dgvMonAn.CurrentRow.Cells["colTenMon"].Value.ToString();
                txtDonGia.Text = dgvMonAn.CurrentRow.Cells["colDonGia"].Value.ToString();
            }
        }
    }
}
