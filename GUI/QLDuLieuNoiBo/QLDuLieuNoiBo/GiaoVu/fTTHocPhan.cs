using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDuLieuNoiBo.GiaoVu
{
    public partial class fTTHocPhan : Form
    {
        private string mahp = "";
        public fTTHocPhan(string mahp)
        {
            this.mahp = mahp;
            InitializeComponent();
            fTTHocPhan_Load(null, null);
            LoadComboBox();
            txtTenHP.Focus();
        }
        private void LoadComboBox()
        {
            // Tham khảo fTTSinhVien
        }
         
        private void fTTHocPhan_Load(object sender, EventArgs e)
        {
            // Xử lý
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Xử lý
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xử lý
        }
    }
}
