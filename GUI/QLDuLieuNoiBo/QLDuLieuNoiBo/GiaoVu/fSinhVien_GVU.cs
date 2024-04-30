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
    public partial class fSinhVien_GVU : Form
    {
        DataTable dtable;
        private string keyword = "";
        public fSinhVien_GVU()
        {
            InitializeComponent();
        }
        private void LoadSinhVien(string keyword)
        {
            keyword = txtKeyword.Text;
            string sql = "SELECT * FROM U_ADMIN.SINHVIEN";

            // Nếu keyword không rỗng, thêm điều kiện tìm kiếm vào câu SQL
            if (!string.IsNullOrEmpty(keyword))
            {
                List<string> columnsToSearch = new List<string>
                {
                    "MASV", "HOTEN", "PHAI", "NGSINH", "DCHI", "DT", "MACT", "MANGANH", "SOTCTL", "DTBTL"
                };

                string condition = string.Join(" OR ", columnsToSearch.Select(col => $"{col} LIKE '%{keyword}%'"));
                sql += $" WHERE {condition}";
            }
            dtable = Database.GetDataToTable(sql);
            dgvDSSinhVien.DataSource = dtable;
        }

        private void fSinhVien_GVU_Load(object sender, EventArgs e)
        {
            LoadSinhVien(null);
        }

        private void dgvDSSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvDSSinhVien.Rows[index];
            Console.WriteLine(selectedRow);
            if (selectedRow != null)
            {
                var masv = selectedRow.Cells["MASV"].Value.ToString();

                // Truyền mã hình thức vào form phiếu đk quảng cáo
                new fTTSinhVien(masv).ShowDialog();

                // Sau khi fPhieuDKQC được đóng lại
                // Load lại ds phiếu đk quảng cáo
                LoadSinhVien(keyword);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new fTTSinhVien(null).ShowDialog();
            LoadSinhVien(null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            keyword = txtKeyword.Text;
            LoadSinhVien(keyword);
        }
    }
}
