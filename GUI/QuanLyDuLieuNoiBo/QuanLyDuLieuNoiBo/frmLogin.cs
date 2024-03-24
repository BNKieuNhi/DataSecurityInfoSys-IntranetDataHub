using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuLieuNoiBo
{
    public partial class frmLogin : Form
    {
        Thread t;
        String username = "", password = "";
        String owner = "U_AD";
        String nhanvien = "NHANVIEN_";
        String thanhtra = "THANHTRA_";
        String benhnhan = "BENHNHAN_";
        String bacsi = "BACSI_";
        String csyt = "CSYT_";
        String ybacsi = "YBACSI_";
        String nghiencuu = "NGHIENCUU_";

        public frmLogin()
        {
            InitializeComponent();
        }
        //OleDbConnection conn = new OleDbConnection("DATA SOURCE=localhost:1521/XE;TNS_ADMIN=C:\\Users\\Admin\\Oracle\\network\\admin;PERSIST SECURITY INFO=True;USER ID='\"C##ADMIN\"'");
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text.Trim();
            password = txtPassword.Text.Trim();

            // Kiem tra xem TK, MK đã nhập hay chua
            if (username != "" && password != "")
            {
                MessageBox.Show("Chưa nhập thông tin Tên tài khoản", "Thông báo");
                txtUsername.Focus();
                return;
            }

            if (txtPassword.Text != null && txtUsername.Text.Trim() != "")
            {
                MessageBox.Show("Chưa nhập thông tin Mật khẩu", "Thông báo");
                txtPassword.Focus();
                return;
            }

            //conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter();
            // So sanh TK, MK với thong tin trong database
            
            frmMain _frmMain = new frmMain();
            _frmMain.Show();
            this.Hide();
        }
    }
}
