using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDuLieuNoiBo.NVCoBan
{
    public partial class fMain_NV : Form
    {
        public string username = "";
        public fMain_NV(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fMain_Load(object sender, EventArgs e)
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

        private void TTCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTTCaNhan _fTTCaNhan = new fTTCaNhan();
            AddForm(_fTTCaNhan);
        }

        private void SinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSinhVien _fSinhVien = new fSinhVien();
            AddForm(_fSinhVien);
        }

        private void DonViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDonVi _fDonVi = new fDonVi();
            AddForm(_fDonVi);
        }

        private void HocPhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHocPhan _fHocPhan = new fHocPhan();
            AddForm(_fHocPhan);
        }

        private void KeHoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKeHoach _fKeHoach = new fKeHoach();
            AddForm(_fKeHoach);
        }
    }
}
