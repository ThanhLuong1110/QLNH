namespace QuanLyNH
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbQLBan = new System.Windows.Forms.ToolStripButton();
            this.tsbQLNhanVien = new System.Windows.Forms.ToolStripButton();
            this.tsbQLMonAn = new System.Windows.Forms.ToolStripButton();
            this.tsbQLHoaDon = new System.Windows.Forms.ToolStripButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQLBan,
            this.tsbQLNhanVien,
            this.tsbQLMonAn,
            this.tsbQLHoaDon});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1262, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbQLBan
            // 
            this.tsbQLBan.Image = ((System.Drawing.Image)(resources.GetObject("tsbQLBan.Image")));
            this.tsbQLBan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQLBan.Name = "tsbQLBan";
            this.tsbQLBan.Size = new System.Drawing.Size(146, 27);
            this.tsbQLBan.Text = "Quản Lý Bàn";
            this.tsbQLBan.Click += new System.EventHandler(this.tsbQLBan_Click);
            // 
            // tsbQLNhanVien
            // 
            this.tsbQLNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("tsbQLNhanVien.Image")));
            this.tsbQLNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQLNhanVien.Name = "tsbQLNhanVien";
            this.tsbQLNhanVien.Size = new System.Drawing.Size(199, 27);
            this.tsbQLNhanVien.Text = "Quản Lý Nhân Viên";
            this.tsbQLNhanVien.Click += new System.EventHandler(this.tsbQLNhanVien_Click);
            // 
            // tsbQLMonAn
            // 
            this.tsbQLMonAn.Image = ((System.Drawing.Image)(resources.GetObject("tsbQLMonAn.Image")));
            this.tsbQLMonAn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQLMonAn.Name = "tsbQLMonAn";
            this.tsbQLMonAn.Size = new System.Drawing.Size(180, 27);
            this.tsbQLMonAn.Text = "Quản Lý Món Ăn";
            this.tsbQLMonAn.Click += new System.EventHandler(this.tsbQLMonAn_Click);
            // 
            // tsbQLHoaDon
            // 
            this.tsbQLHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("tsbQLHoaDon.Image")));
            this.tsbQLHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQLHoaDon.Name = "tsbQLHoaDon";
            this.tsbQLHoaDon.Size = new System.Drawing.Size(188, 27);
            this.tsbQLHoaDon.Text = "Quản Lý Hoá Đơn";
            this.tsbQLHoaDon.Click += new System.EventHandler(this.tsbQLHoaDon_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.AutoSize = true;
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 30);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1262, 643);
            this.pnlContent.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "Quản Lý Nhà Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbQLBan;
        private System.Windows.Forms.ToolStripButton tsbQLNhanVien;
        private System.Windows.Forms.ToolStripButton tsbQLMonAn;
        private System.Windows.Forms.ToolStripButton tsbQLHoaDon;
        private System.Windows.Forms.Panel pnlContent;
    }
}