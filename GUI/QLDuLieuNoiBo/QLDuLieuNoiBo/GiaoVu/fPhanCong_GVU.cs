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
    public partial class fPhanCong_GVU : Form
    {
        DataTable dtable;
        public fPhanCong_GVU()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            string sql = "select * from U_ADMIN.PHANCONG";
            dtable = Database.GetDataToTable(sql);

            dgvDSPhanCong.DataSource = dtable;
        }

        private void fPhanCong_GVU_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
