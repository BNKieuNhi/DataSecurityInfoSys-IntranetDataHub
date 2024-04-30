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
    public partial class fKeHoach : Form
    {
        DataTable dtable;
        public fKeHoach()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            string sql = "select * from U_ADMIN.KHMO";
            dtable = Database.GetDataToTable(sql);

            dgvDSDonVi.DataSource = dtable;
        }

        private void fKeHoach_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
