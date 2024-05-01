using QLDuLieuNoiBo.TruongDonVi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDuLieuNoiBo.TruongKhoa
{
    public partial class fNhanSu_TK : Form
    {
        DataTable dtable;
        string keyword = "";
        public fNhanSu_TK()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            txtManv.Text = "";
            txtManv.Visible = false;
            lblManv.Visible = false;

            btnThem.Visible = true;
            btnDelete.Visible = true;
            btnCancel.Visible = true;
            btnRecord.Visible = false;
            btnCancel.Visible = false;

            btnThem.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void fNhanSu_TK_Load(object sender, EventArgs e)
        {
            Reset();
            LoadNhanSu(null);
        }

        private void LoadNhanSu(string keyword)
        {
            keyword = txtKeyword.Text;
            string sql = "SELECT * FROM U_ADMIN.NHANSU";

            // Nếu keyword không rỗng, thêm điều kiện tìm kiếm vào câu SQL
            // Xử lý: Kiểm tra thêm trường hợp có check trưởng đv thì thêm điều kiện tìm kiếm dựa trên những hp làm trưởng

            if (!string.IsNullOrEmpty(keyword))
            {
                List<string> columnsToSearch = new List<string>
                {
                    "MANV", "HOTEN", "PHAI", "NGSINH", "PHUCAP", "DT", "VAITRO", "MADV", "USERNAME"
                };

                string condition = string.Join(" OR ", columnsToSearch.Select(col => $"{col} LIKE '%{keyword}%'"));
                sql += $" WHERE {condition}";
            }
            dtable = Database.GetDataToTable(sql);
            dgvNhanSu.DataSource = dtable;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new fTTinNhanSu(null).ShowDialog();

            btnSearch_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtManv.Visible = true;
            lblManv.Visible = true;
            btnRecord.Visible = true;
            btnCancel.Visible = true;

            btnDelete.Enabled = false;
            btnThem.Enabled = false;
        }


        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtManv.Text))
            {
                MessageBox.Show("Yêu cầu điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string manv = txtManv.Text;
            string sql = "DELETE FROM U_ADMIN.NHANSU " +
                      $"WHERE MANV = '{manv}'";


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

            LoadNhanSu(null);
            Reset();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgvNhanSu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvNhanSu.Rows[index];
            Console.WriteLine(selectedRow);
            if (selectedRow != null)
            {
                var manv = selectedRow.Cells["MANV"].Value.ToString();

                new fTTinNhanSu(manv).ShowDialog();

                // Sau khi fTTNhanSu được đóng lại
                // Load lại ds NhanSu
                LoadNhanSu(keyword);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            keyword = txtKeyword.Text;
            LoadNhanSu(keyword);
        }
    }
}
