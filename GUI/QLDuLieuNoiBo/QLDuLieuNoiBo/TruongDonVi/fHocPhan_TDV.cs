using QLDuLieuNoiBo.GiaoVu;
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
    public partial class fHocPhan_TDV : Form
    {
        DataTable dtable;
        string keyword = "";
        public fHocPhan_TDV()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            if (!chkBoxTrgHP.Checked)
            {
                txtKeyword.Text = "";
                txtMahp.Text = "";

                txtMahp.Visible = false;
                lblMahp.Visible = false;

                btnThem.Visible = false;
                btnDelete.Visible = false;
                btnCancel.Visible = false;
                btnRecord.Visible = false;
                btnCancel.Visible = false;
            }
            else 
            {
                txtMahp.Text = "";
                txtMahp.Visible = false;
                lblMahp.Visible = false;

                btnThem.Visible = true;
                btnDelete.Visible = true;
                btnCancel.Visible = true;
                btnRecord.Visible = false;
                btnCancel.Visible = false;

                btnThem.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void LoadHocPhan(string keyword)
        {
            keyword = txtKeyword.Text;
            string sql = "SELECT * FROM U_ADMIN.HOCPHAN";

            // Nếu keyword không rỗng, thêm điều kiện tìm kiếm vào câu SQL
            // Xử lý: Kiểm tra thêm trường hợp có check trưởng đv thì thêm điều kiện tìm kiếm dựa trên những hp làm trưởng
            if (!string.IsNullOrEmpty(keyword))
            {
                List<string> columnsToSearch = new List<string>
                {
                    "MAHP", "TENHP", "SOTC", "STLT", "STTH", "SOSVTD", "MADV"
                };

                string condition = string.Join(" OR ", columnsToSearch.Select(col => $"{col} LIKE '%{keyword}%'"));
                sql += $" WHERE {condition}";
            }
            dtable = Database.GetDataToTable(sql);
            dgvHocPhan.DataSource = dtable;
        }

        private void fHocPhan_TDV_Load(object sender, EventArgs e)
        {
            chkBoxTrgHP.Checked = false;
            Reset();
            LoadHocPhan(null);
        }
        private void dgvHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new GiaoVu.fTTHocPhan(null).ShowDialog();
            LoadHocPhan(null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            keyword = txtKeyword.Text;
            LoadHocPhan(keyword);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new fTTHocPhan(null).ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtMahp.Visible = true;
            lblMahp.Visible = true;
            btnRecord.Visible = true;
            btnCancel.Visible = true;

            btnDelete.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            // Xử lý: Tham khảo GiaoVu.fHocPhan_GVU
            LoadHocPhan(null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void chkBoxTrgHP_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
