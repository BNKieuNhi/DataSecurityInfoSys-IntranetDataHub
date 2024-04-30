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
    public partial class fDonVi : Form
    {
        DataTable dtable;
        public fDonVi()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            string sql = "select * from U_ADMIN.DONVI";
            dtable = Database.GetDataToTable(sql);

            dgvDSDonVi.DataSource = dtable;
        }

        private void fDonVi_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
