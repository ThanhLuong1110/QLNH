namespace QuanLyNH
{
    partial class ucHoaDon
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gpbChiTietHoaDon = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvChiTietHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gpbHoaDon = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHuyTim = new Guna.UI2.WinForms.Guna2Button();
            this.dtpNgayLap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnHuyTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHoaDon = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.gpbDoanhThuTheoNgay = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbChiTietHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.gpbHoaDon.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.gpbDoanhThuTheoNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbChiTietHoaDon
            // 
            this.gpbChiTietHoaDon.Controls.Add(this.dgvChiTietHD);
            this.gpbChiTietHoaDon.CustomBorderColor = System.Drawing.Color.LightSlateGray;
            this.gpbChiTietHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbChiTietHoaDon.ForeColor = System.Drawing.Color.Black;
            this.gpbChiTietHoaDon.Location = new System.Drawing.Point(1134, 113);
            this.gpbChiTietHoaDon.Margin = new System.Windows.Forms.Padding(20);
            this.gpbChiTietHoaDon.Name = "gpbChiTietHoaDon";
            this.gpbChiTietHoaDon.Size = new System.Drawing.Size(857, 343);
            this.gpbChiTietHoaDon.TabIndex = 43;
            this.gpbChiTietHoaDon.Text = "Chi tiết hóa đơn";
            // 
            // dgvChiTietHD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTietHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTietHD.ColumnHeadersHeight = 40;
            this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMon,
            this.colDonGia,
            this.colSoLuong,
            this.colTenNV,
            this.colTenMon,
            this.colGhiChu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiTietHD.Location = new System.Drawing.Point(0, 40);
            this.dgvChiTietHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChiTietHD.Name = "dgvChiTietHD";
            this.dgvChiTietHD.RowHeadersVisible = false;
            this.dgvChiTietHD.RowHeadersWidth = 51;
            this.dgvChiTietHD.RowTemplate.Height = 24;
            this.dgvChiTietHD.Size = new System.Drawing.Size(857, 303);
            this.dgvChiTietHD.TabIndex = 0;
            this.dgvChiTietHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiTietHD.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTietHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvChiTietHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvChiTietHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvChiTietHD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiTietHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiTietHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvChiTietHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvChiTietHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvChiTietHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChiTietHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChiTietHD.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvChiTietHD.ThemeStyle.ReadOnly = false;
            this.dgvChiTietHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChiTietHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiTietHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTietHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvChiTietHD.ThemeStyle.RowsStyle.Height = 24;
            this.dgvChiTietHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChiTietHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // colMaMon
            // 
            this.colMaMon.DataPropertyName = "MaMon";
            this.colMaMon.HeaderText = "Mã món";
            this.colMaMon.MinimumWidth = 6;
            this.colMaMon.Name = "colMaMon";
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colTenNV
            // 
            this.colTenNV.DataPropertyName = "HoTen";
            this.colTenNV.HeaderText = "Tên Nhân Viên";
            this.colTenNV.MinimumWidth = 6;
            this.colTenNV.Name = "colTenNV";
            // 
            // colTenMon
            // 
            this.colTenMon.DataPropertyName = "TenMon";
            this.colTenMon.HeaderText = "Tên Món";
            this.colTenMon.MinimumWidth = 6;
            this.colTenMon.Name = "colTenMon";
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            // 
            // dgvHoaDon
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHoaDon.ColumnHeadersHeight = 40;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.GhiChu,
            this.colMaNV,
            this.colNgayLap,
            this.colMaBan,
            this.colTongTien,
            this.colTrangThai});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 110);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(1036, 577);
            this.dgvHoaDon.TabIndex = 8;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvHoaDon.ThemeStyle.ReadOnly = false;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHoaDon.ThemeStyle.RowsStyle.Height = 24;
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick_1);
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            this.dgvHoaDon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHoaDon_CellFormatting);
            // 
            // gpbHoaDon
            // 
            this.gpbHoaDon.BorderColor = System.Drawing.Color.DarkGray;
            this.gpbHoaDon.BorderRadius = 5;
            this.gpbHoaDon.Controls.Add(this.guna2Panel1);
            this.gpbHoaDon.Controls.Add(this.dgvHoaDon);
            this.gpbHoaDon.CustomBorderColor = System.Drawing.Color.LightSlateGray;
            this.gpbHoaDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbHoaDon.ForeColor = System.Drawing.Color.Black;
            this.gpbHoaDon.Location = new System.Drawing.Point(47, 113);
            this.gpbHoaDon.Margin = new System.Windows.Forms.Padding(20);
            this.gpbHoaDon.Name = "gpbHoaDon";
            this.gpbHoaDon.Size = new System.Drawing.Size(1047, 770);
            this.gpbHoaDon.TabIndex = 41;
            this.gpbHoaDon.Text = "Danh sách hóa đơn";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnHuyTim);
            this.guna2Panel1.Controls.Add(this.dtpNgayLap);
            this.guna2Panel1.Controls.Add(this.btnHuyTimKiem);
            this.guna2Panel1.Controls.Add(this.txtTimKiem);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 50);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1036, 57);
            this.guna2Panel1.TabIndex = 9;
            // 
            // btnHuyTim
            // 
            this.btnHuyTim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyTim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuyTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuyTim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuyTim.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyTim.ForeColor = System.Drawing.Color.White;
            this.btnHuyTim.Location = new System.Drawing.Point(457, 5);
            this.btnHuyTim.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.btnHuyTim.Name = "btnHuyTim";
            this.btnHuyTim.Size = new System.Drawing.Size(59, 30);
            this.btnHuyTim.TabIndex = 11;
            this.btnHuyTim.Text = "❌";
            this.btnHuyTim.Click += new System.EventHandler(this.btnHuyTim_Click);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Checked = true;
            this.dtpNgayLap.FillColor = System.Drawing.Color.White;
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayLap.Location = new System.Drawing.Point(187, 5);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.dtpNgayLap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayLap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(269, 30);
            this.dtpNgayLap.TabIndex = 10;
            this.dtpNgayLap.Value = new System.DateTime(2026, 1, 9, 14, 17, 10, 947);
            this.dtpNgayLap.ValueChanged += new System.EventHandler(this.dtpNgayLap_ValueChanged);
            // 
            // btnHuyTimKiem
            // 
            this.btnHuyTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuyTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuyTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuyTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnHuyTimKiem.Location = new System.Drawing.Point(771, 5);
            this.btnHuyTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyTimKiem.Name = "btnHuyTimKiem";
            this.btnHuyTimKiem.Size = new System.Drawing.Size(56, 30);
            this.btnHuyTimKiem.TabIndex = 9;
            this.btnHuyTimKiem.Text = "✖";
            this.btnHuyTimKiem.Click += new System.EventHandler(this.btnHuyTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderRadius = 5;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(586, 5);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(241, 30);
            this.txtTimKiem.TabIndex = 8;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged_1);
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = false;
            this.lblHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.lblHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHoaDon.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.Location = new System.Drawing.Point(0, 0);
            this.lblHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(348, 60);
            this.lblHoaDon.TabIndex = 4;
            this.lblHoaDon.Text = "Thông tin hóa đơn";
            this.lblHoaDon.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Controls.Add(this.lblHoaDon);
            this.guna2Panel6.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel6.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel6.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(2056, 60);
            this.guna2Panel6.TabIndex = 42;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gpbDoanhThuTheoNgay
            // 
            this.gpbDoanhThuTheoNgay.Controls.Add(this.chartDoanhThu);
            this.gpbDoanhThuTheoNgay.CustomBorderColor = System.Drawing.Color.LightSlateGray;
            this.gpbDoanhThuTheoNgay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDoanhThuTheoNgay.ForeColor = System.Drawing.Color.Black;
            this.gpbDoanhThuTheoNgay.Location = new System.Drawing.Point(1226, 496);
            this.gpbDoanhThuTheoNgay.Margin = new System.Windows.Forms.Padding(20);
            this.gpbDoanhThuTheoNgay.Name = "gpbDoanhThuTheoNgay";
            this.gpbDoanhThuTheoNgay.Size = new System.Drawing.Size(667, 345);
            this.gpbDoanhThuTheoNgay.TabIndex = 45;
            this.gpbDoanhThuTheoNgay.Text = "Doanh thu theo ngày";
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(0, 40);
            this.chartDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(667, 305);
            this.chartDoanhThu.TabIndex = 44;
            this.chartDoanhThu.Text = "chart1";
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MaHD";
            this.colMaHD.HeaderText = "Mã HD";
            this.colMaHD.MinimumWidth = 6;
            this.colMaHD.Name = "colMaHD";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = false;
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            // 
            // colNgayLap
            // 
            this.colNgayLap.DataPropertyName = "NgayLap";
            this.colNgayLap.HeaderText = "Ngày Lập";
            this.colNgayLap.MinimumWidth = 6;
            this.colNgayLap.Name = "colNgayLap";
            // 
            // colMaBan
            // 
            this.colMaBan.DataPropertyName = "MaBan";
            this.colMaBan.HeaderText = "Mã Bàn";
            this.colMaBan.MinimumWidth = 6;
            this.colMaBan.Name = "colMaBan";
            // 
            // colTongTien
            // 
            this.colTongTien.DataPropertyName = "TongTien";
            this.colTongTien.HeaderText = "Tông Tiền";
            this.colTongTien.MinimumWidth = 6;
            this.colTongTien.Name = "colTongTien";
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // ucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gpbChiTietHoaDon);
            this.Controls.Add(this.gpbDoanhThuTheoNgay);
            this.Controls.Add(this.gpbHoaDon);
            this.Controls.Add(this.guna2Panel6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucHoaDon";
            this.Size = new System.Drawing.Size(2056, 946);
            this.Load += new System.EventHandler(this.ucHoaDon_Load);
            this.gpbChiTietHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.gpbHoaDon.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.gpbDoanhThuTheoNgay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gpbChiTietHoaDon;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChiTietHD;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHoaDon;
        private Guna.UI2.WinForms.Guna2GroupBox gpbHoaDon;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHoaDon;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayLap;
        private Guna.UI2.WinForms.Guna2Button btnHuyTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2GroupBox gpbDoanhThuTheoNgay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private Guna.UI2.WinForms.Guna2Button btnHuyTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
