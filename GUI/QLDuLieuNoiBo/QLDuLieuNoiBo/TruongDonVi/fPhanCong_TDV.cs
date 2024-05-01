using QLDuLieuNoiBo.GiangVien;
using QLDuLieuNoiBo.GiaoVu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDuLieuNoiBo.TruongDonVi
{
    public partial class fPhanCong_TDV : Form
    {
        DataTable dtable;
        string keyword = "";
        string role = "";
        public fPhanCong_TDV(string role)
        {
            InitializeComponent();
            this.role = role;
        }
        private void Reset()
        {
            txtMahp.Text = "";
            txtMahp.Visible = false;
            lblMahp.Visible = false;
            txtMaGV.Text = "";
            txtMaGV.Visible = false;
            lblMaGV.Visible = false;    

            btnThem.Visible = true;
            btnDelete.Visible = true;
            btnCancel.Visible = true;
            btnRecord.Visible = false;
            btnCancel.Visible = false;

            btnThem.Enabled = true;
            btnDelete.Enabled = true;
        }
        private void LoadPhanCong(string keyword)
        {
            keyword = txtKeyword.Text;
            string sql = "";
            if (role == "tdv")
            {
                sql = "SELECT * FROM U_ADMIN.V_XEMTTINPCTHEODONVI";
            }

            else if (role == "tk")
            {
                sql = "SELECT * FROM U_ADMIN.V_PHANCONG_VPK";
            }

            // Nếu keyword không rỗng, thêm điều kiện tìm kiếm vào câu SQL
            // Xử lý: Kiểm tra thêm trường hợp có check trưởng đv thì thêm điều kiện tìm kiếm dựa trên những hp làm trưởng

            if (!string.IsNullOrEmpty(keyword))
            {
                List<string> columnsToSearch = new List<string>
                {
                    "MAGV", "MAHP", "HK", "NAM", "MACT"
                };

                string condition = string.Join(" OR ", columnsToSearch.Select(col => $"{col} LIKE '%{keyword}%'"));
                sql += $" WHERE {condition}";
            }
            dtable = Database.GetDataToTable(sql);
            dgvPhanCong.DataSource = dtable;
        }

        private void fPhanCong_TDV_Load(object sender, EventArgs e)
        {
            Reset();
            LoadPhanCong(null);
        }
        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new GiaoVu.fTTHocPhan(null).ShowDialog();
            LoadPhanCong(null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            keyword = txtKeyword.Text;
            LoadPhanCong(keyword);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new fTTPhanCong_TDV(null, null, null, null, null).ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtMahp.Visible = true;
            lblMahp.Visible = true;
            btnRecord.Visible = true;
            btnCancel.Visible = true;
            txtMaGV.Visible = true;
            lblMaGV.Visible = true;

            btnDelete.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaGV.Text) || string.IsNullOrEmpty(txtMahp.Text))
            {
                MessageBox.Show("Yêu cầu điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string magv = txtMaGV.Text;
            string mahp = txtMahp.Text;
            string sql = "DELETE FROM U_ADMIN.PHANCONG " +
                      $"WHERE MAGV = '{magv}' " +
                      $"AND MAHP = '{mahp}'";
                      /*$"AND MAHP = '{mahp}' " +
                      $"AND MAHP = '{mahp}' " +
                      $"AND MAHP = '{mahp}' " +*/


            int res = new Database().Execute(sql);
            if (res == 1) // nếu thực thi thành công
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else // nếu không thành công
            {
                Console.WriteLine(res);
                MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadPhanCong(null);
            Reset();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgvPhanCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvPhanCong.Rows[index];
            Console.WriteLine(selectedRow);
            if (selectedRow != null)
            {
                var mahp = selectedRow.Cells["MAHP"].Value.ToString();
                var magv = selectedRow.Cells["MAGV"].Value.ToString();
                var hk = selectedRow.Cells["HK"].Value.ToString();
                var nam = selectedRow.Cells["NAM"].Value.ToString();
                var mact = selectedRow.Cells["MACT"].Value.ToString();

                new fTTPhanCong_TDV(mahp, magv, hk, nam, mact).ShowDialog();

                // Sau khi fTTPhanCong được đóng lại
                // Load lại ds phancong
                LoadPhanCong(keyword);
            }
        }

        private void dgvPhanCong_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPhanCong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvPhanCong.Rows[index];
            Console.WriteLine(selectedRow);
            if (selectedRow != null)
            {
                var mahp = selectedRow.Cells["MAHP"].Value.ToString();
                var magv = selectedRow.Cells["MAGV"].Value.ToString();
                var hk = selectedRow.Cells["HK"].Value.ToString();
                var nam = selectedRow.Cells["NAM"].Value.ToString();
                var mact = selectedRow.Cells["MACT"].Value.ToString();

                new fTTPhanCong_TDV(mahp, magv, hk, nam, mact).ShowDialog();

                // Sau khi fTTPhanCong được đóng lại
                // Load lại ds phancong
                LoadPhanCong(keyword);
            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
