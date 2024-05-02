using QLDuLieuNoiBo.GiangVien;
using QLDuLieuNoiBo.NVCoBan;
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
    public partial class fHocPhan_GVU : Form
    {
        DataTable dtable;
        string keyword = "";
        public fHocPhan_GVU()
        {
            InitializeComponent();
        }
        private void LoadHocPhan(string keyword)
        {
            keyword = txtKeyword.Text;
            string sql = "SELECT * FROM U_ADMIN.HOCPHAN";

            // Nếu keyword không rỗng, thêm điều kiện tìm kiếm vào câu SQL
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

        private void fHocPhan_GVU_Load(object sender, EventArgs e)
        {
            LoadHocPhan(null);
        }

        private void dgvHocPhan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // tham khảo GiaoVu.fTTSinhVien
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
    }
}
