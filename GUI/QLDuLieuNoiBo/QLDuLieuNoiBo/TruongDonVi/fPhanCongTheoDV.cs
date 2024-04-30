using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDuLieuNoiBo.TruongDonVi
{
    public partial class fPhanCongTheoDV : Form
    {
        DataTable dtable;
        public fPhanCongTheoDV()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            string sql = "select * from U_ADMIN.V_XEMPCGVCHUNGDONVI";
            dtable = Database.GetDataToTable(sql);

            dgvDSPhanCong.DataSource = dtable;
        }

        private void fPhanCongTheoDV_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
