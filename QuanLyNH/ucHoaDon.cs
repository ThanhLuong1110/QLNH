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
using System.Windows.Forms.DataVisualization.Charting;
using static QuanLyNH.QLDB;

namespace QuanLyNH
{
    public partial class ucHoaDon : UserControl
    {
        public ucHoaDon()
        {
            InitializeComponent();
        }
        private void ucHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM HoaDon";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvHoaDon.DataSource = dt;
                }
                else
                {
                    dgvHoaDon.DataSource = null;
                    //MessageBox.Show("Không có hóa đơn nào trong cơ sở dữ liệu.");
                }
                LoadChartDoanhThuFromDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu hóa đơn: " + ex.Message);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM HoaDon WHERE MaHD LIKE @TuKhoa OR MaBan LIKE @TuKhoa OR MaNV LIKE @TuKhoa";
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(
                    query,
                    new SqlParameter("@TuKhoa", "%" + txtTimKiem.Text.Trim() + "%")
                );

                if (dt.Rows.Count > 0)
                {
                    dgvHoaDon.DataSource = dt; // hiển thị kết quả lên DataGridView
                }
                //else
                //{
                //    MessageBox.Show("Không tìm thấy hóa đơn phù hợp.");
                //    dgvHoaDon.DataSource = null; // xóa dữ liệu cũ nếu không có kết quả
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ucHoaDon_Load(sender, e); // gọi lại hóa đơn
                //dtpNgayLap.Value = DateTime.Now; // hóa đơn trong ngày hôm nay
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hủy tìm theo ngày: " + ex.Message);
            }
        }
        private void LoadChiTietHoaDon(string maHD)
        {
            string query = @"
                SELECT ct.MaMon, ct.DonGia, ct.SoLuong, ct.GhiChu, ma.TenMon, nv.HoTen
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

                dgvChiTietHD.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết hóa đơn: " + ex.Message);
            }
        }
        private void dgvHoaDon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHD = dgvHoaDon.Rows[e.RowIndex].Cells["colMaHD"].Value.ToString();
                LoadChiTietHoaDon(maHD);
            }
        }
        private void LoadChartDoanhThuFromDB()
        {
            chartDoanhThu.Series.Clear();
            chartDoanhThu.ChartAreas.Clear();
            chartDoanhThu.Titles.Clear();

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Title = "Ngày";
            area.AxisY.Title = "Doanh thu (VNĐ)";
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            chartDoanhThu.ChartAreas.Add(area);

            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;
            series.IsValueShownAsLabel = true;
            series.Label = "#VALY{N0} VNĐ";

            string sql = @"
                SELECT 
                    CAST(NgayLap AS DATE) AS Ngay,
                    SUM(TongTien) AS DoanhThu
                    FROM HoaDon
                    GROUP BY CAST(NgayLap AS DATE)
                    ORDER BY Ngay";

            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(sql);

                foreach (DataRow row in dt.Rows)
                {
                    string ngay = Convert.ToDateTime(row["Ngay"]).ToString("dd/MM");
                    double doanhThu = Convert.ToDouble(row["DoanhThu"]);
                    series.Points.AddXY(ngay, doanhThu);
                }

                chartDoanhThu.Series.Add(series);
                chartDoanhThu.Titles.Add("Biểu đồ doanh thu theo ngày");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load chart doanh thu: " + ex.Message);
            }
        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM HoaDon WHERE CONVERT(date, NgayLap) = @NgayLap";
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(
                    query,
                    new SqlParameter("@NgayLap", dtpNgayLap.Value.Date)
                );

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvHoaDon.DataSource = dt; // hiển thị kết quả lên DataGridView
                }
                else
                {
                    dgvHoaDon.DataSource = null; // xóa dữ liệu cũ nếu không có kết quả
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc hóa đơn: " + ex.Message);
            }
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM HoaDon WHERE MaHD LIKE @TuKhoa OR MaBan LIKE @TuKhoa OR MaNV LIKE @TuKhoa";
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(
                    query,
                    new SqlParameter("@TuKhoa", "%" + txtTimKiem.Text.Trim() + "%")
                );

                if (dt.Rows.Count > 0)
                {
                    dgvHoaDon.DataSource = dt; // hiển thị kết quả lên DataGridView
                }
                else
                {
                    dgvHoaDon.DataSource = null; // xóa dữ liệu cũ nếu không có kết quả
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void btnHuyTim_Click(object sender, EventArgs e)
        {
            ucHoaDon_Load(sender, e);
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            ucHoaDon_Load(sender, e);
            txtTimKiem.Clear();
        }
        private void dgvHoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "colTrangThai"
                && e.Value != null)
            {
                int trangThai = Convert.ToInt32(e.Value);

                switch (trangThai)
                {
                    case 0:
                        e.Value = "Đang phục vụ";
                        break;
                    case 1:
                        e.Value = "Đã thanh toán";
                        break;

                }

                e.FormattingApplied = true;
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
