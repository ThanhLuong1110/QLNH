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
        private string maBanDangChon = "";
        private string maMonDangChon = "";
       // private string tenMonDangChon = "";
        private string maMonCanSuaXoa = "";
        public ucQLBan()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                string queryBan = "SELECT * FROM Ban";
                DataTable dt = DatabaseHelper.ExecuteQuery(queryBan);

                string queryMonAn = "SELECT * FROM MonAn";
                dgvDanhSachMonAn.DataSource = DatabaseHelper.ExecuteQuery(queryMonAn);

                dgvDanhSachBan.DataSource = dt;

                dgvDanhSachBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDanhSachMonAn.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void ucQLBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private string MaHDTuMaBan(string maBan)
        {
            try
            {
                string query = "SELECT MaHD FROM HoaDon WHERE MaBan = '" + maBan + "' AND TrangThai = 0";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["MaHD"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy MaHD: " + ex.Message);
            }
            return "";
        }

        private void LoadChiTietMonAn(string maHD)
        {
            try
            {
                dgvChiTietBan.AutoGenerateColumns = false;

                if (dgvChiTietBan.Columns.Contains("colGhiChu"))
                {
                    dgvChiTietBan.Columns["colGhiChu"].DataPropertyName = "GhiChu";
                }

                string query = @"SELECT 
                            c.MaMon,
                            m.TenMon,      
                            c.SoLuong, 
                            c.DonGia,
                            c.GhiChu,
                            (c.SoLuong * c.DonGia) AS ThanhTien
                         FROM ChiTietHD c 
                         JOIN MonAn m ON c.MaMon = m.MaMon 
                         WHERE c.MaHD = '" + maHD + "'";

                dgvChiTietBan.DataSource = DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load chi tiết món: " + ex.Message);
            }
        }

        private void dgvDanhSachBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhSachBan.CurrentRow != null)
            {
                try
                {
                    DataGridViewRow row = dgvDanhSachBan.Rows[e.RowIndex];

                    maBanDangChon = row.Cells["colMaBan"].Value?.ToString();
                    lblMaBan.Text = row.Cells["colMaBan"].Value?.ToString();
                    txtMaBan.Text = row.Cells["colMaBan"].Value?.ToString();
                    nudSoChoNgoi.Text = row.Cells["colSoChoNgoi"].Value?.ToString();
                    cbxTrangThai.Text = row.Cells["colTrangThai"].Value?.ToString();

                    string maHD = MaHDTuMaBan(maBanDangChon);

                    if (!string.IsNullOrEmpty(maHD))
                    {
                        txtMaHD.Text = maHD;
                        LoadChiTietMonAn(maHD);
                        HienThiTongTien(maHD);
                    }
                    else
                    {
                        txtMaHD.Text = "";
                        if (dgvChiTietBan.DataSource is DataTable dt) dt.Clear();
                        else dgvChiTietBan.DataSource = null;

                        lblTongTien.Text = "0 VNĐ";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn bàn: " + ex.Message);
                }
            }
        }

        private void LoadChiTietBan(string maHD)
        {
            string query = @"
                SELECT ma.TenMon, ct.DonGia, ct.SoLuong
                FROM ChiTietHD ct
                JOIN MonAn ma ON ct.MaMon = ma.MaMon
                JOIN HoaDon hd ON ct.MaHD = hd.MaHD
                JOIN NhanVien nv ON hd.MaNV = nv.MaNV                
                WHERE ct.MaHD = @MaHD";
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(
                    query,
                    new SqlParameter("@MaHD", maHD)
                );

                dgvChiTietBan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết hóa đơn: " + ex.Message);
            }
        }

        private void HienThiTongTien(string maHD)
        {
            try
            {
                string query = "SELECT TongTien FROM HoaDon WHERE MaHD = '" + maHD + "'";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    object ketQua = dt.Rows[0]["TongTien"];

                    if (ketQua != DBNull.Value)
                    {
                        decimal tongTien = Convert.ToDecimal(ketQua);
                        lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
                    }
                    else
                    {
                        lblTongTien.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị tiền: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM MonAn WHERE MaMon LIKE @TuKhoa OR TenMon LIKE @TuKhoa OR DonGia LIKE @TuKhoa";
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(
                    query,
                    new SqlParameter("@TuKhoa", "%" + txtSearch.Text.Trim() + "%")
                );

                if (dt.Rows.Count > 0)
                {
                    dgvDanhSachMonAn.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnLamMoiBan_Click(object sender, EventArgs e)
        {
            txtMaBan.Clear();
            nudSoChoNgoi.Value = 0;
            cbxTrangThai.SelectedIndex = -1;

            maBanDangChon = "";

            LoadData();
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBan.Text) || string.IsNullOrWhiteSpace(nudSoChoNgoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string sql = "INSERT INTO Ban (MaBan, SoChoNgoi, TrangThai) VALUES (@MaBan, @SoChoNgoi, @TrangThai)";

            try
            {
                DatabaseHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@MaBan", txtMaBan.Text),
                    new SqlParameter("@SoChoNgoi", nudSoChoNgoi.Text),
                    new SqlParameter("@TrangThai", cbxTrangThai.Text)
                );
                MessageBox.Show("Thêm thành công!");
                btnLamMoiBan_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi thêm: " + ex.Message); }
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maBanDangChon)) { MessageBox.Show("Chưa bàn để xóa!"); return; }

            if (MessageBox.Show("Bạn có chắc muốn xóa bàn này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM Ban WHERE MaBan=@MaBan";
                try
                {
                    DatabaseHelper.ExecuteNonQuery(sql, new SqlParameter("@MaBan", maBanDangChon));
                    MessageBox.Show("Đã xóa!");
                    btnLamMoiBan_Click(sender, e);
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xóa (Có thể bàn đang dính dữ liệu Hóa đơn): " + ex.Message); }
            }
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maBanDangChon)) { MessageBox.Show("Vui lòng chọn bàn cần sửa!"); return; }

            string sql = "UPDATE Ban SET SoChoNgoi=@SoChoNgoi, TrangThai=@TrangThai WHERE MaBan=@MaBan";

            try
            {
                DatabaseHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@MaBan", txtMaBan.Text),
                    new SqlParameter("@SoChoNgoi", nudSoChoNgoi.Text),
                    new SqlParameter("@TrangThai", cbxTrangThai.Text)
                );
                MessageBox.Show("Sửa thành công!");
                btnLamMoiBan_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi sửa: " + ex.Message); }
        }

        private void dgvDanhSachMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhSachMonAn.CurrentRow != null)
            {
                DataGridViewRow row = dgvDanhSachMonAn.Rows[e.RowIndex];
                maMonDangChon = row.Cells["colMaMonDS"].Value?.ToString();
                txtTenMon.Text = row.Cells["colTenMonDS"].Value?.ToString();
            }
        }

        private void ThemMonVaoChiTiet(string maHD, string maMon, int soLuong, string ghiChu)
        {
            string queryGia = "SELECT DonGia FROM MonAn WHERE MaMon = '" + maMon + "'";
            DataTable dtGia = DatabaseHelper.ExecuteQuery(queryGia);
            decimal donGia = 0;
            if (dtGia.Rows.Count > 0)
            {
                donGia = Convert.ToDecimal(dtGia.Rows[0]["DonGia"]);
            }

            string queryKiemTra = "SELECT * FROM ChiTietHD WHERE MaHD = '" + maHD + "' AND MaMon = '" + maMon + "'";
            DataTable dtKiemTra = DatabaseHelper.ExecuteQuery(queryKiemTra);

            if (dtKiemTra.Rows.Count > 0)
            {
                string updateGhiChu = "";

                if (!string.IsNullOrEmpty(ghiChu))
                {
                    updateGhiChu = ", GhiChu = N'" + ghiChu + "'";
                }

                string queryUpdate = "UPDATE ChiTietHD SET SoLuong = SoLuong + " + soLuong +
                                     " WHERE MaHD = '" + maHD + "' AND MaMon = '" + maMon + "'";
                DatabaseHelper.ExecuteQuery(queryUpdate);
            }
            else
            {
                string queryInsert = string.Format(
                    "INSERT INTO ChiTietHD (MaHD, MaMon, SoLuong, DonGia, GhiChu) VALUES ('{0}', '{1}', {2}, {3}, N'{4}')",
            maHD, maMon, soLuong, donGia, ghiChu);

                DatabaseHelper.ExecuteQuery(queryInsert);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maBanDangChon))
            {
                MessageBox.Show("Vui lòng chọn bàn cần thêm món!");
                return;
            }
            if (string.IsNullOrEmpty(maMonDangChon))
            {
                MessageBox.Show("Vui lòng chọn món ăn trong thực đơn!");
                return;
            }
            int soLuong = (int)nudSoLuong.Value;
            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
                return;
            }

            string ghiChu = txtGhiChu.Text.Trim();

            try
            {
                string maHD = MaHDTuMaBan(maBanDangChon);

                if (string.IsNullOrEmpty(maHD))
                {
                    maHD = "HD" + DateTime.Now.ToString("ddMMyyHHmmss");
                    string maNV = "NV001";

                    string queryTaoHD = string.Format(
                        "INSERT INTO HoaDon (MaHD, NgayLap, MaBan, TrangThai, MaNV, TongTien) VALUES ('{0}', GETDATE(), '{1}', 0, '{2}', 0)",
                        maHD, maBanDangChon, maNV);

                    DatabaseHelper.ExecuteQuery(queryTaoHD);
                }

                string queryUpdateBan = string.Format(
                    "UPDATE Ban SET TrangThai = N'Có Khách' WHERE MaBan = '{0}'",
                    maBanDangChon);

                DatabaseHelper.ExecuteQuery(queryUpdateBan);

                ThemMonVaoChiTiet(maHD, maMonDangChon, soLuong, ghiChu);

                LoadChiTietMonAn(maHD);
                HienThiTongTien(maHD);

                nudSoLuong.Value = 1;
                txtTenMon.Clear();
                txtGhiChu.Clear();

                LoadData();

                cbxTrangThai.Text = "Có Khách";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maBanDangChon) || string.IsNullOrEmpty(maMonCanSuaXoa))
            {
                MessageBox.Show("Vui lòng chọn món ăn trong danh sách chi tiết để sửa!");
                return;
            }

            int soLuongMoi = (int)nudSoLuong.Value;
            if (soLuongMoi <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
                return;
            }

            try
            {
                string maHD = MaHDTuMaBan(maBanDangChon);
                string ghiChuMoi = txtGhiChu.Text.Trim();

                string queryUpdate = string.Format(
                    "UPDATE ChiTietHD SET SoLuong = {0}, GhiChu = N'{1}' WHERE MaHD = '{2}' AND MaMon = '{3}'",
                    soLuongMoi, ghiChuMoi, maHD, maMonCanSuaXoa);

                DatabaseHelper.ExecuteQuery(queryUpdate);

                LoadChiTietMonAn(maHD);
                HienThiTongTien(maHD);

                MessageBox.Show("Đã cập nhật món ăn!");

                txtTenMon.Clear();
                txtGhiChu.Clear();
                nudSoLuong.Value = 1;
                maMonCanSuaXoa = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa món: " + ex.Message);
            }
        }

        private void dgvChiTietBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvChiTietBan.CurrentRow != null)
            {
                DataGridViewRow row = dgvChiTietBan.Rows[e.RowIndex];

                if (row.Cells["colMaMon"].Value != null)
                {
                    maMonCanSuaXoa = row.Cells["colMaMon"].Value.ToString();
                }

                txtTenMon.Text = row.Cells["colTenMon"].Value?.ToString();
                txtGhiChu.Text = row.Cells["colGhiChu"].Value?.ToString();

                if (row.Cells["colSoLuong"].Value != null)
                    nudSoLuong.Value = Convert.ToDecimal(row.Cells["colSoLuong"].Value);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maBanDangChon) || string.IsNullOrEmpty(maMonCanSuaXoa))
            {
                MessageBox.Show("Vui lòng chọn món ăn trong danh sách chi tiết để xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa món này khỏi bàn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string maHD = MaHDTuMaBan(maBanDangChon);

                    string queryDelete = string.Format(
                        "DELETE FROM ChiTietHD WHERE MaHD = '{0}' AND MaMon = '{1}'",
                        maHD, maMonCanSuaXoa);

                    DatabaseHelper.ExecuteQuery(queryDelete);

                    string queryCount = "SELECT COUNT(*) FROM ChiTietHD WHERE MaHD = '" + maHD + "'";
                    DataTable dtCount = DatabaseHelper.ExecuteQuery(queryCount);

                    if (dtCount.Rows.Count > 0 && Convert.ToInt32(dtCount.Rows[0][0]) == 0)
                    {
                        string queryUpdateBan = "UPDATE Ban SET TrangThai = N'Trống' WHERE MaBan = '" + maBanDangChon + "'";
                        DatabaseHelper.ExecuteQuery(queryUpdateBan);

                        cbxTrangThai.Text = "Trống";

                    }

                    LoadChiTietMonAn(maHD);
                    HienThiTongTien(maHD);

                    LoadData();

                    MessageBox.Show("Đã xóa món!");

                    txtTenMon.Clear();
                    txtGhiChu.Clear();
                    nudSoLuong.Value = 1;
                    maMonCanSuaXoa = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa món: " + ex.Message);
                }
            }
        }

        private void btnLamMoiMA_Click(object sender, EventArgs e)
        {
            txtTenMon.Text = "";
            txtGhiChu.Clear();
            nudSoLuong.Value = 0;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem có bàn nào được chọn không
            if (string.IsNullOrEmpty(maBanDangChon))
            {
                MessageBox.Show("Vui lòng chọn bàn cần thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy mã hóa đơn chưa thanh toán của bàn đó
            string maHD = MaHDTuMaBan(maBanDangChon);
            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Bàn này hiện đang trống hoặc không có hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3. Tính tổng tiền chính xác từ ChiTietHD trước khi chốt
            decimal tongTien = 0;
            try
            {
                string queryTongTien = "SELECT SUM(SoLuong * DonGia) FROM ChiTietHD WHERE MaHD = '" + maHD + "'";
                DataTable dtTien = DatabaseHelper.ExecuteQuery(queryTongTien);

                if (dtTien.Rows.Count > 0 && dtTien.Rows[0][0] != DBNull.Value)
                {
                    tongTien = Convert.ToDecimal(dtTien.Rows[0][0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính tiền: " + ex.Message);
                return;
            }

            // 4. Hỏi xác nhận thanh toán
            DialogResult result = MessageBox.Show(
                string.Format("Bạn có chắc chắn muốn thanh toán cho bàn {0}?\nTổng tiền: {1:N0} VNĐ", maBanDangChon, tongTien),
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // --- BƯỚC 5: CẬP NHẬT CƠ SỞ DỮ LIỆU ---

                    // A. Cập nhật bảng HoaDon: Set TrangThai = 1, Update TongTien
                    string sqlUpdateHD = string.Format(
                        "UPDATE HoaDon SET TrangThai = 1, TongTien = {0} WHERE MaHD = '{1}'",
                        tongTien, maHD);
                    DatabaseHelper.ExecuteNonQuery(sqlUpdateHD);

                    // B. Cập nhật bảng Ban: Trả về trạng thái 'Trống'
                    string sqlUpdateBan = string.Format(
                        "UPDATE Ban SET TrangThai = N'Trống' WHERE MaBan = '{0}'",
                        maBanDangChon);
                    DatabaseHelper.ExecuteNonQuery(sqlUpdateBan);


                    // ---------------------------------------------------------
                    // --- BƯỚC 6: CODE MỚI THÊM VÀO ĐÂY (IN HÓA ĐƠN) ---
                    // ---------------------------------------------------------

                    DialogResult inHoaDon = MessageBox.Show("Thanh toán thành công! Bạn có muốn in hóa đơn không?",
                                                            "Hoàn tất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (inHoaDon == DialogResult.Yes)
                    {
                        // Gọi Form in hoá đơn và truyền Mã Hoá Đơn (maHD) sang
                        // Form này là form bạn đã tạo ở bước trước có chứa ReportViewer
                        frmInHoaDon f = new frmInHoaDon(maHD);
                        f.ShowDialog();
                    }
                    // ---------------------------------------------------------


                    // --- BƯỚC 7: RESET GIAO DIỆN (Làm sạch màn hình) ---

                    // Reset các biến và control
                    txtMaHD.Text = "";
                    lblTongTien.Text = "0 VNĐ";
                    txtTenMon.Clear();
                    txtGhiChu.Clear();
                    nudSoLuong.Value = 1;

                    // Xóa lưới chi tiết món ăn (vì bàn đã trống)
                    if (dgvChiTietBan.DataSource is DataTable dt)
                        dt.Clear();
                    else
                        dgvChiTietBan.DataSource = null;

                    // Load lại danh sách bàn để cập nhật màu sắc (Xanh/Đỏ)
                    LoadData();

                    // Reset trạng thái form nhập liệu về mặc định
                    btnLamMoiBan_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}