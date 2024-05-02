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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string sql = "select * from U_ADMIN.KHMO";
            dtable = Database.GetDataToTable(sql);

            dgvDonVi.DataSource = dtable;
        }

        private void fKeHoach_GVU_Load(object sender, EventArgs e)
        {
            // Tham khảo fDonVi_GVU
            GetData();

            //Load Combobox
            LoadComBox();

        }

        private void LoadComBox() {
            //Load MaCT
            string sqlMaCT = "SELECT DISTINCT MACT FROM U_ADMIN.KHMO";
            dtable = Database.GetDataToTable(sqlMaCT);

            foreach (DataRow row in dtable.Rows)
            {
                cbBoxMaCT.Items.Add(row["MaCT"].ToString());
            }

        }


        private void dgvDonVi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvDonVi.Rows[index];
            Console.WriteLine(selectedRow);
            if (selectedRow != null)
            {
                txtMahp.Text = selectedRow.Cells["MAHP"].Value.ToString();
                cbBoxMaCT.Text = selectedRow.Cells["MACT"].Value.ToString();
                txtHocKy.Text = selectedRow.Cells["HK"].Value.ToString();
                txtNam.Text = selectedRow.Cells["NAM"].Value.ToString();
           
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            gboxAction.Text = "Thêm";
            State = "Insert";
            txtMahp.Text = "";
            cbBoxMaCT.Text = "";
            txtHocKy.Text = "";
            txtNam.Text = "";
            

            //Focus();

            btnThem.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Enabled = true;
            btnRecord.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gboxAction.Text = "Sửa";
            State = "Update";

            //txtTenDonVi.Focus();

            btnThem.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Enabled = true;
            btnRecord.Enabled = true;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            /*if (txtTenDonVi.Text.Trim().Length == 0 || cbBoxTrgDonVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/ 

            string mahp = txtMahp.Text;
            string hocky = txtHocKy.Text;
            string nam = txtNam.Text;
            string mact = cbBoxMaCT.Text;

            string mahp_new = textBox3.Text; 
            string hocky_new = textBox2.Text;
            string nam_new = textBox1.Text;
            string mact_new = comboBox1.Text;


            string sql = "";

            if (State == "Insert")
            {
                // Nếu đang thêm mới
                sql = $"INSERT INTO U_ADMIN.KHMO (MAHP, HK, NAM, MACT) VALUES ('{mahp}', '{hocky}', '{nam}', '{mact}')";
            }
            else if (State == "Update")
            {
                // Nếu đang cập nhật
                //sql = $"UPDATE U_ADMIN.KHMO SET MAHP = '{mahp}', HK = '{hocky}', NAM = '{nam}', MACT = '{mact}' WHERE MAHP = {mahp_old} AND HK = {hocky_old} AND NAM = {nam_old} AND MACT = {mact_old}";

                sql = $"UPDATE U_ADMIN.KHMO SET MAHP = '{mahp_new}', HK = '{hocky_new}', NAM = '{nam_new}', MACT = '{mact_new}' WHERE MAHP = '{mahp}' AND HK = '{hocky}' AND NAM = '{nam}' AND MACT = '{mact}'";

            }

            // Thực thi câu lệnh SQL
            var res = new Database().Execute(sql);

            // Xử lý kết quả thực thi
            if (res == 1)
            {
                MessageBox.Show(State == "Insert" ? "Thêm mới thành công!" : "Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                GetData();
            }
            else
            {
                MessageBox.Show("Error: Thực thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset(); 
        }

        private void cbBoxMaCT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMahp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHocKy_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
