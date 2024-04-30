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
    public partial class fKQHocPhan : Form
    {
        DataTable dtable;
        public fKQHocPhan()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            string sql = "select * from U_ADMIN.V_XEMDANGKY";
            dtable = Database.GetDataToTable(sql);

            dgvDSKQHP.DataSource = dtable;
        }

        private void fKQHocPhan_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dgvDSKQHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvDSKQHP.Rows[index];
            Console.WriteLine(selectedRow);
            if (selectedRow != null)
            {
                txtSinhVien.Text = selectedRow.Cells["MASV"].Value.ToString();
                txtNamHoc.Text = selectedRow.Cells["NAM"].Value.ToString();
                txtHocPhan.Text = selectedRow.Cells["MAHP"].Value.ToString();
                txtDiemQT.Text = selectedRow.Cells["DIEMQT"].Value.ToString();
                txtDiemTH.Text = selectedRow.Cells["DIEMTH"].Value.ToString();
                txtDiemCK.Text = selectedRow.Cells["DIEMCK"].Value.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtDiemQT.Text == "" || txtDiemTH.Text == "" || txtDiemCK.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string sql =
                "UPDATE U_ADMIN.V_XEMDANGKY SET " +
                "DIEMQT = " + txtDiemQT.Text + ", " +
                "DIEMTH = " + txtDiemTH.Text + ", " +
                "DIEMCK = " + txtDiemCK.Text + " " +
                "WHERE MASV = " + txtSinhVien.Text + " AND MAHP = " + txtHocPhan.Text;

                var res = new Database().Execute(sql);
                if (res == 1)
                {
                    Database.ExeCute("COMMIT");
                    MessageBox.Show("Cập nhật điểm thoại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật điểm thoại thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GetData();
            }
        }
    }
}
