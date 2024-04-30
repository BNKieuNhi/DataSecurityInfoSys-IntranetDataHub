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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLDuLieuNoiBo.GiaoVu
{
    public partial class fMain_GVU : Form
    {
        public string username = "";
        public fMain_GVU(string username)
        {
            this.username = username;
            InitializeComponent();
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

        private void fMain_GVU_Load(object sender, EventArgs e)
        {
            lblUsername.Text = username;
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TTCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTTCaNhan _fTTCaNhan = new fTTCaNhan();
            AddForm(_fTTCaNhan);
        }

        private void SinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSinhVien_GVU _fSinhVien_GVU = new fSinhVien_GVU();
            AddForm(_fSinhVien_GVU);
        }

        private void DonViToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*            fDonVi_GVU _fDonVi_GVU = new fDonVi_GVU();
            AddForm(_fDonVi_GVU);*/
        }

        private void HocPhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*            fHocPhan_GVU _fHocPhan_GVU = new fHocPhan_GVU();
            AddForm(_fHocPhan_GVU);*/
        }

        private void KeHoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*            fKeHoach_GVU _fKeHoach_GVU = new fKeHoach_GVU();
            AddForm(_fKeHoach_GVU);*/
        }

        private void PhanCongToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void KQHPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
