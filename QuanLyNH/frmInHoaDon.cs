using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyNH.QLDB;

namespace QuanLyNH
{
    public partial class frmInHoaDon : Form
    {
        private string _maHD; // Biến lưu mã hóa đơn được truyền sang

        // Constructor nhận maHD
        public frmInHoaDon(string maHD)
        {
            InitializeComponent();
            _maHD = maHD;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_maHD)) return;

            try
            {
                // --- BƯỚC 1: LẤY DỮ LIỆU HEADER (Cho dsHoaDon) ---
                // Lấy các cột bạn cần hiển thị ở phần đầu: MaHD, MaBan, MaNV...
                string queryHeader = @"SELECT MaHD, MaBan, MaNV, NgayLap, TongTien 
                               FROM HoaDon 
                               WHERE MaHD = '" + _maHD + "'";

                DataTable dtHeader = DatabaseHelper.ExecuteQuery(queryHeader);


                // --- BƯỚC 2: LẤY DỮ LIỆU CHI TIẾT (Cho dsInHoaDon) ---
                // Lấy danh sách món: TenMon, SoLuong, DonGia
                string queryDetails = @"SELECT m.TenMon, ct.SoLuong, ct.DonGia 
                                FROM ChiTietHD ct
                                JOIN MonAn m ON ct.MaMon = m.MaMon
                                WHERE ct.MaHD = '" + _maHD + "'";

                DataTable dtDetails = DatabaseHelper.ExecuteQuery(queryDetails);


                // --- BƯỚC 3: ĐẨY DỮ LIỆU VÀO REPORT ---

                // Xóa dữ liệu cũ
                this.rpvInHoaDon.LocalReport.DataSources.Clear();

                // 3a. Nguồn cho Header
                // "dsHoaDon" phải giống y hệt tên dataset 1 trong file report
                ReportDataSource rdsHeader = new ReportDataSource("dsHoaDon", dtHeader);
                this.rpvInHoaDon.LocalReport.DataSources.Add(rdsHeader);

                // 3b. Nguồn cho Danh sách món
                // "dsInHoaDon" phải giống y hệt tên dataset 2 trong file report
                ReportDataSource rdsDetails = new ReportDataSource("dsInHoaDon", dtDetails);
                this.rpvInHoaDon.LocalReport.DataSources.Add(rdsDetails);

                // 3c. Cấu hình đường dẫn và hiển thị
                this.rpvInHoaDon.LocalReport.ReportPath = "report.rdlc";
                this.rpvInHoaDon.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị hóa đơn: " + ex.Message);
            }
        }

        
    }
}
