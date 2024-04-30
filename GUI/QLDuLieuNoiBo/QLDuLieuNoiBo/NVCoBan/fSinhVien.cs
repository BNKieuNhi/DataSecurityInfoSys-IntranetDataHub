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
    public partial class fSinhVien : Form
    {
        DataTable dtable;
        public fSinhVien()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            string sql = "select * from U_ADMIN.SINHVIEN";
            dtable = Database.GetDataToTable(sql);

            dgvDSSinhVien.DataSource = dtable;
        }
        private void fSinhVien_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
