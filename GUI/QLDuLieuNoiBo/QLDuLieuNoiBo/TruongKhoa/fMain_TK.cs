using QLDuLieuNoiBo.GiangVien;
using QLDuLieuNoiBo.GiaoVu;
using QLDuLieuNoiBo.NVCoBan;
using QLDuLieuNoiBo.TruongDonVi;
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

namespace QLDuLieuNoiBo.TruongKhoa
{
    public partial class fMain_TK : Form
    {
        public string username;
        public fMain_TK(string username)
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

        private void PCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPhanCong_GVU _fPhanCong_GVU = new fPhanCong_GVU();
            AddForm(_fPhanCong_GVU);
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
            fHocPhan _fHocPhan_TDV = new fHocPhan();
            AddForm(_fHocPhan_TDV);
        }

        private void KeHoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKeHoach _fKeHoach = new fKeHoach();
            AddForm(_fKeHoach);
        }

        private void KQHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKQHocPhan _fKQHocPhan = new fKQHocPhan();
            AddForm(_fKQHocPhan);
        }

        private void theoCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPhanCong _fPhanCong = new fPhanCong();
            AddForm(_fPhanCong);
        }

        private void HPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPhanCong_TDV _fPhanCong_TDV = new fPhanCong_TDV("tk");
            AddForm(_fPhanCong_TDV);
        }

        private void fMain_TK_Load(object sender, EventArgs e)
        {
            lblUsername.Text = username;
        }

        private void ThongBaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongBao _fThongBao = new fThongBao();
            AddForm(_fThongBao);
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin _fLogin = new fLogin();
            _fLogin.Show();
        }

        private void NhanSuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhanSu_TK _fNhanSu = new fNhanSu_TK();
            AddForm(_fNhanSu);
        }
    }
}
