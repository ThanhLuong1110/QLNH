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
    public partial class ucQuanLyNhanVien : UserControl
    {
        private string maNVDangChon = "";

        public ucQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void ucQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {

            try
            {
                string query = @"
                    SELECT nv.MaNV, nv.HoTen, nv.NgaySinh, nv.QueQuan, nv.SoDT, nv.ChucVu,
                    tk.TenDangNhap, tk.MatKhau
                    FROM NhanVien nv
                    JOIN TaiKhoan tk ON nv.MaNV = tk.MaNV
                    Where nv.TrangThai = 1;";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                dgvDanhSachnhanVien.DataSource = dt;
                                
                dgvDanhSachnhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }


        }

        private void dgvDanhSachnhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhSachnhanVien.CurrentRow != null)
            {
                DataGridViewRow row = dgvDanhSachnhanVien.Rows[e.RowIndex];

                maNVDangChon = row.Cells["colMaNV"].Value?.ToString();

                txtMaNV.Text = row.Cells["colMaNV"].Value?.ToString();
                txtHoTen.Text = row.Cells["colHoTen"].Value?.ToString();
                txtQueQuan.Text = row.Cells["colQueQuan"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["colSoDT"].Value?.ToString(); 
                cbxChucVu.Text = row.Cells["colChucVu"].Value?.ToString();
                txtTaiKhoan.Text = row.Cells["colTaiKhoan"].Value?.ToString();
                txtMatKhau.Text = row.Cells["colMatKhau"].Value?.ToString();

                if (row.Cells["colNgaySinh"].Value != DBNull.Value)
                {
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["colNgaySinh"].Value);
                }
             
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtQueQuan.Clear();
            txtSoDienThoai.Clear();
            cbxChucVu.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();

            maNVDangChon = "";

            LoadData(); 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string sql = "INSERT INTO NhanVien (MaNV, HoTen, NgaySinh, QueQuan, SoDT, ChucVu) VALUES (@MaNV, @HoTen, @NgaySinh, @QueQuan, @SoDT, @ChucVu)";

            try
            {            
                DatabaseHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@MaNV", txtMaNV.Text),
                    new SqlParameter("@HoTen", txtHoTen.Text),
                    new SqlParameter("@NgaySinh", dtpNgaySinh.Value),
                    new SqlParameter("@QueQuan", txtQueQuan.Text),
                    new SqlParameter("@SoDT", txtSoDienThoai.Text),
                    new SqlParameter("@ChucVu", cbxChucVu.Text)
                );
                MessageBox.Show("Thêm thành công!");
                btnLamMoi_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi thêm: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maNVDangChon)) { MessageBox.Show("Vui lòng chọn nhân viên cần sửa!"); return; }

            string sql = "UPDATE NhanVien SET HoTen=@HoTen, NgaySinh=@NgaySinh, QueQuan=@QueQuan, SoDT=@SoDT, ChucVu=@ChucVu WHERE MaNV=@MaNV";

            try
            {
                DatabaseHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@MaNV", txtMaNV.Text),
                    new SqlParameter("@HoTen", txtHoTen.Text),
                    new SqlParameter("@NgaySinh", dtpNgaySinh.Value),
                    new SqlParameter("@QueQuan", txtQueQuan.Text),
                    new SqlParameter("@SoDT", txtSoDienThoai.Text),
                    new SqlParameter("@ChucVu", cbxChucVu.Text)
                );
                MessageBox.Show("Sửa thành công!");
                btnLamMoi_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi sửa: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maNVDangChon)) { MessageBox.Show("Chưa chọn nhân viên để xóa!"); return; }

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "UPDATE NhanVien SET TrangThai = 0 WHERE MaNV=@MaNV";
                try
                {
                    DatabaseHelper.ExecuteNonQuery(sql, new SqlParameter("@MaNV", maNVDangChon));
                    MessageBox.Show("Đã xóa!");
                    btnLamMoi_Click(sender, e);
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xóa (Có thể nhân viên đang dính dữ liệu Hóa đơn): " + ex.Message); }
            }
        }

        private void dgvDanhSachnhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

