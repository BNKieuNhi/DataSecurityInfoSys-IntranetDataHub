using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDuLieuNoiBo.GiangVien
{
    public partial class fPhanCong : Form
    {
        DataTable dtable;
        public fPhanCong()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            string sql = "select * from U_ADMIN.V_XEMPHANCONG";
            dtable = Database.GetDataToTable(sql);

            dgvDSPhanCong.DataSource = dtable;
        }

        private void fPhanCong_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
