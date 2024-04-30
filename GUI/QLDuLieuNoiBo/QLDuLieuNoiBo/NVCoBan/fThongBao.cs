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
    public partial class fThongBao : Form
    {
        DataTable dtable;
        public fThongBao()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            string sql = "select * from U_ADMIN.THONGBAO";
            dtable = Database.GetDataToTable(sql);

            dgvThongBao.DataSource = dtable;
        }
        private void fThongBao_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
