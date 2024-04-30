using Oracle.ManagedDataAccess.Client;
using QLDuLieuNoiBo.GiangVien;
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
    public partial class fDonVi_GVU : Form
    {
        DataTable dtable;
        public static string State = "-1";
        string madv = "";
        string[] trg_donvi = new string[] { "2","3","4","5","6","7" };
        public fDonVi_GVU()
        {
            InitializeComponent();
            fDonVi_GVU_Load(null, null);
        }
        private void Reset()
        {
            State = "-1";
            gboxAction.Text = "Thông tin";
            txtTenDonVi.Text = "";
            cbBoxTrgDonVi.Text = "";

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
/*        private List<string> GetTruongDonViList()
        {
            List<string> truongDonViList = new List<string>();
            string sql = "SELECT MANV FROM U_ADMIN.NHANSU WHERE USERNAME LIKE 'TDV_%'";
            DataTable all_TrgDV = Database.GetDataToTable(sql);
            foreach (DataRow row in all_TrgDV.Rows)
            {
                truongDonViList.Add(row["MANV"].ToString());
            }

            return truongDonViList;
        }*/
        private void LoadComboBox()
        {
            foreach (string col in trg_donvi)
            {
                cbBoxTrgDonVi.Items.Add(col);
            }
        }
        private void fDonVi_GVU_Load(object sender, EventArgs e)
        {
            Reset();
            LoadComboBox();
            GetData();
        }

        private void dgvDonVi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvDonVi.Rows[index];
            Console.WriteLine(selectedRow);
            if (selectedRow != null)
            {
                txtTenDonVi.Text = selectedRow.Cells["TENDV"].Value.ToString();
                cbBoxTrgDonVi.Text = selectedRow.Cells["TRGDV"].Value.ToString();
                madv = selectedRow.Cells["MADV"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gboxAction.Text = "Thêm";
            State = "Insert";
            txtTenDonVi.Text = "";
            cbBoxTrgDonVi.Text = "";

            txtTenDonVi.Focus();

            btnThem.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Enabled = true;
            btnRecord.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gboxAction.Text = "Sửa";
            State = "Update";

            txtTenDonVi.Focus();

            btnThem.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Enabled = true;
            btnRecord.Enabled = true;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (txtTenDonVi.Text.Trim().Length == 0 || cbBoxTrgDonVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tendv = txtTenDonVi.Text;
            string trgdv = cbBoxTrgDonVi.Text;

            string sql = "";

            if (State == "Insert")
            {
                // Nếu đang thêm mới
                sql = $"INSERT INTO U_ADMIN.DONVI (TENDV, TRGDV) VALUES ('{tendv}', '{trgdv}')";
            }
            else if (State == "Update")
            {
                // Nếu đang cập nhật
                sql = $"UPDATE U_ADMIN.DONVI SET TENDV = '{tendv}', TRGDV = '{trgdv}' WHERE MADV = {madv}";
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
    }
}
