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
                string query = "SELECT * FROM NhanVien";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                dgvDanhSachnhanVien.DataSource = dt;

                string[] cotCanAn = { "NgaySinh", "QueQuan", "SoDT", "MatKhau" };

                foreach (string tenCot in cotCanAn)
                {
                    if (dgvDanhSachnhanVien.Columns.Contains(tenCot))
                        dgvDanhSachnhanVien.Columns[tenCot].Visible = false;
                }

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
            // 1. Kiểm tra xem đã chọn nhân viên chưa
            if (string.IsNullOrEmpty(maNVDangChon))
            {
                MessageBox.Show("Chưa chọn nhân viên để xóa!");
                return;
            }

            // 2. Hỏi xác nhận
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này? \n(Lưu ý: Tài khoản đăng nhập của nhân viên này cũng sẽ bị xóa)",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // BƯỚC 1: Xóa Tài Khoản trước (Để gỡ ràng buộc khóa ngoại FK_TaiKhoan_NhanVien)
                    string sqlDeleteTaiKhoan = "DELETE FROM TaiKhoan WHERE MaNV = @MaNV";
                    DatabaseHelper.ExecuteNonQuery(sqlDeleteTaiKhoan, new SqlParameter("@MaNV", maNVDangChon));

                    // BƯỚC 2: Sau khi xóa tài khoản xong, mới xóa đến Nhân Viên
                    string sqlDeleteNhanVien = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                    DatabaseHelper.ExecuteNonQuery(sqlDeleteNhanVien, new SqlParameter("@MaNV", maNVDangChon));

                    MessageBox.Show("Đã xóa nhân viên và tài khoản liên quan!");

                    // BƯỚC 3: Làm mới lại giao diện
                    btnLamMoi_Click(sender, e);
                }
                catch (Exception ex)
                {
                    // Trường hợp lỗi khác (Ví dụ: Nhân viên này đã lập Hóa Đơn - dính khóa ngoại bảng HoaDon)
                    MessageBox.Show("Không thể xóa nhân viên này.\nLý do: " + ex.Message + "\n\n(Gợi ý: Nếu nhân viên đã từng lập hóa đơn, bạn không thể xóa họ khỏi hệ thống để bảo toàn lịch sử giao dịch).");
                }
            }
        }
    }
}