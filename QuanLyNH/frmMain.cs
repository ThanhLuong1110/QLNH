using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static QuanLyNH.Session;


namespace QuanLyNH
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsbQLBan_Click(object sender, EventArgs e)
        {          
            ucQLBan uc = new ucQLBan();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(uc);
            uc.BringToFront();
        }

        private void tsbQLNhanVien_Click(object sender, EventArgs e)
        {
            ucQuanLyNhanVien uc = new ucQuanLyNhanVien();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(uc);
            uc.BringToFront();
        }

        private void tsbQLMonAn_Click(object sender, EventArgs e)
        {
            QuanLyMonAn uc = new QuanLyMonAn();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(uc);
            uc.BringToFront();
        }

        private void tsbQLHoaDon_Click(object sender, EventArgs e)
        {
            ucHoaDon uc = new ucHoaDon();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(uc);
            uc.BringToFront();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
