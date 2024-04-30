using QLDuLieuNoiBo.NVCoBan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDuLieuNoiBo.GiangVien
{
    public partial class fMain_GV : Form
    {
        public string username = "";
        public fMain_GV(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        private void fMain_GV_Load(object sender, EventArgs e)
        {
            lblUsername.Text = username;
            /*fWelcome _fWelcome = new fWelcome();
            AddForm(_fWelcome);*/
        }
        private void AddForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }
        private void thoatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TTCaNhanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fTTCaNhan _fTTCaNhan = new fTTCaNhan();
            AddForm(_fTTCaNhan);
        }

        private void SinhVienToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fSinhVien _fSinhVien = new fSinhVien();
            AddForm(_fSinhVien);
        }

        private void DonViToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fDonVi _fDonVi = new fDonVi();
            AddForm(_fDonVi);
        }

        private void HocPhanToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fHocPhan _fHocPhan = new fHocPhan();
            AddForm(_fHocPhan);
        }

        private void KeHoachToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fKeHoach _fKeHoach = new fKeHoach();
            AddForm(_fKeHoach);
        }

        private void PhanCongToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fPhanCong _fPhanCong = new fPhanCong();
            AddForm(_fPhanCong);
        }

        private void KQHPToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fKQHocPhan _fKQHocPhan = new fKQHocPhan();
            AddForm(_fKQHocPhan);
        }

        private void ThongBaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongBao _fThongBao = new fThongBao();
            AddForm(_fThongBao);
        }
    }
}
