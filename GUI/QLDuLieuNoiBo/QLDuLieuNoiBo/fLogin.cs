/*using QLDuLieuNoiBo.Admin;
using QLDuLieuNoiBo.TruongKhoa;*/
using QLDuLieuNoiBo.NVCoBan;
using QLDuLieuNoiBo.GiangVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using QLDuLieuNoiBo.GiaoVu;
using QLDuLieuNoiBo.TruongDonVi;
using QLDuLieuNoiBo.SinhVien;

namespace QLDuLieuNoiBo
{
    public partial class fLogin : Form
    {
        #region tham_so
        public string vaitro = "";
        public string taikhoan = "";
        public string matkhau = "";
        public string loaitk = "";
        public string user_id = "";
        #endregion
        public fLogin()
        {
            InitializeComponent();
        }
        private void fLogin_Load(object sender, EventArgs e)
        {

            var db = new Database();

            txtUsername.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region ktra_rbuoc
            // Kiểm tra ràng buộc
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên tài khoản!", "Tài khoản không được để trống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập password!", "Password không được để trống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Select();
                return;
            }
            #endregion

            taikhoan = txtUsername.Text;
            matkhau = txtPassword.Text;

            #region switchtk
            string loaitk = "";
            if (taikhoan == "U_ADMIN")
            {
                loaitk = "admin";
            }
            else if (taikhoan.StartsWith("TK_"))
            {
                loaitk = "truongkhoa";
            }
            else if (taikhoan.StartsWith("TDV_"))
            {
                loaitk = "truongdonvi";
            }
            else if (taikhoan.StartsWith("GV_"))
            {
                loaitk = "giangvien";
            }
            else if (taikhoan.StartsWith("GVU_"))
            {
                loaitk = "giaovu";
            }
            else if (taikhoan.StartsWith("NVCB_"))
            {
                loaitk = "nhanviencoban";
            }
            else if (taikhoan.StartsWith("SV_"))
            {
                loaitk = "sinhvien";
            }
            #endregion

            Login(taikhoan, matkhau);

            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            switch (loaitk)
            {
                case "admin":
                    fMain _fMain = new fMain();
                    _fMain.Show();
                    break;
                case "nhanviencoban":
                    NVCoBan.fMain_NV _fMain_NV = new fMain_NV(taikhoan);
                    _fMain_NV.Show();
                    break;
                case "giangvien":
                    GiangVien.fMain_GV _fMain_GV = new fMain_GV(taikhoan);
                    _fMain_GV.Show();
                    break;
                case "giaovu":
                    GiaoVu.fMain_GVU _fMain_GVU = new fMain_GVU(taikhoan);
                    _fMain_GVU.Show();
                    break;
                case "truongdonvi":
                    TruongDonVi.fMain_TDV _fMain_TDV = new fMain_TDV(taikhoan);
                    _fMain_TDV.Show();
                    break;
                  case "truongkhoa":
                    fMain_TK _fMain_TK = new fMain_TK(taikhoan);
                    _fMain_TK.Show();
                    break;

                case "sinhvien":
                    SinhVien.fMain_SV  _fMain_SV = new fMain_SV(taikhoan);
                    _fMain_SV.Show();
                    break;
            }
                this.Hide();
            
/*            else // nếu không thành công
            {
                Console.WriteLine(res);
                MessageBox.Show("Error: Vui lòng kiểm tra lại Tài khoản hoặc Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private void Login(String taikhoan, String matkhau)
        {
            try
            {
                Database.InitConnection(taikhoan, matkhau);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
