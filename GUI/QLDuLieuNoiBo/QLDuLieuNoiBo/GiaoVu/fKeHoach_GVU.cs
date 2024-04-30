using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace QLDuLieuNoiBo.GiaoVu
{
    public partial class fKeHoach_GVU : Form
    {
        DataTable dtable;
        public static string State = "-1";
        // Tham khảo fDonVi_GVU
        public fKeHoach_GVU()
        {
            InitializeComponent();
            fKeHoach_GVU_Load(null, null);
        }
        private void Reset()
        {
            State = "-1";
            gboxAction.Text = "Thông tin";
            txtMahp.Text = "";
            cbBoxMaCT.Text = "";
            txtHocKy.Text = "";
            txtNam.Text = "";

            btnThem.Enabled = true;
            btnEdit.Enabled = true;
            btnCancel.Enabled = false;
            btnRecord.Enabled = false;
        }
        private void GetData()
        {
            string sql = "select * from U_ADMIN.DONVI";
            dtable = Database.GetDataToTable(sql);

            dgvDonVi.DataSource = dtable;
        }

        private void fKeHoach_GVU_Load(object sender, EventArgs e)
        {
            // Tham khảo fDonVi_GVU
        }

        private void dgvDonVi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
