using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDuLieuNoiBo.SinhVien
{
    public partial class fMain_SV : Form
    {
        public string username = "";
        public fMain_SV(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin _fLogin = new fLogin();
            _fLogin.Show();
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

        private void HocPhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHocPhan_SV _fHocPhan_SV = new fHocPhan_SV();
            AddForm(_fHocPhan_SV);
        }

        private void DangKiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDangKi  _fDangKi = new fDangKi();
            AddForm(_fDangKi);
        }

        private void KeHoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*            fKeHoach _fKeHoach = new fKeHoach();
            AddForm(_fKeHoach);*/
        }

        private void ThongBaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NVCoBan.fThongBao _fThongBao = new NVCoBan.fThongBao();
            AddForm(_fThongBao);
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
