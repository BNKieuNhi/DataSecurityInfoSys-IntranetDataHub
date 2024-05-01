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

namespace QLDuLieuNoiBo.TruongDonVi
{
    public partial class fTTPhanCong_TDV : Form
    {
        private string mahp = "";
        private string magv = "";
        private string nam = "";
        private string hk = "";
        private string mact = "";
        public static string State = "-1";
        DataTable dtable;
        string[] hk_choices = new string[] { "1", "2", "3" };
        string[] mact_daotao = new string[] { "CQ", "CTTT", "CLC", "VP" };
        public fTTPhanCong_TDV(string mahp, string magv, string hk, string nam, string mact)
        {
            this.mahp = mahp;
            this.magv = magv;
            this.hk = hk;
            this.nam = nam;
            this.mact = mact;
            InitializeComponent();
            fTTPhanCong_TDV_Load(null, null);
            LoadComboBox();
            txtMahp.Focus();
        }

        private void LoadComboBox()
        {
            foreach (string num in hk_choices)
            {
                cbBoxHK.Items.Add(num);
            }

            foreach (string col in mact_daotao)
            {
                cbBoxMact.Items.Add(col);
            }
        }

        private void fTTPhanCong_TDV_Load(object sender, EventArgs e)
        {
            // nếu không có masv => thêm mới sinh viên
            if (string.IsNullOrEmpty(magv) && string.IsNullOrEmpty(mahp) && string.IsNullOrEmpty(mact)
                && string.IsNullOrEmpty(nam) && string.IsNullOrEmpty(hk))
            {
                this.Text = "Thêm mới phân công";
                State = "Insert";
            }
            else
            {
                this.Text = "Cập nhật phân công";
                State = "Update";

                // Lấy thông tin chi tiết của 1 SV dựa vào mã sv
                // masv được truyền từ form fSinhVien
                string sql = "select * from U_ADMIN.PHANCONG where MAHP = " + mahp + " AND MAGV = " + magv ;
                dtable = Database.GetDataToTable(sql);
                if (dtable.Rows.Count > 0)
                {
                    // Set các giá trị vào component của form
                    txtMagv.Text = dtable.Rows[0]["MAGV"].ToString();
                    cbBoxHK.Text = dtable.Rows[0]["HK"].ToString();
                    txtMahp.Text = dtable.Rows[0]["MAHP"].ToString();
                    cbBoxMact.Text = dtable.Rows[0]["MACT"].ToString();
                    txtNam.Text = dtable.Rows[0]["Nam"].ToString();

                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string magv = txtMagv.Text;
            string mahp = txtMahp.Text;
            string mact = cbBoxMact.Text;
            string hk = cbBoxHK.Text;
            string nam = txtNam.Text;

            if (State == "Insert")
            {
                sql = "INSERT INTO U_ADMIN.PHANCONG (MAGV, MAHP, HK, NAM, MACT) " +
                      $"VALUES ('{magv}', '{mahp}', " +
                      $"'{hk}', '{nam}', '{mact}')";
            }
            else if (State == "Update")
            {
                sql = $"UPDATE U_ADMIN.PHANCONG SET MAGV = '{magv}' " +
                      $"WHERE MAHP = '{mahp}' AND HK = '{hk}' " +
                      $"AND NAM = '{nam}' AND MACT = '{mact}'";
            }

            var res = new Database().Execute(sql);
            if (res == 1)
            {
                MessageBox.Show(State == "Insert" ? "Thêm mới thành công!" : "Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error: Thực thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
