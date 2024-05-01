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
    public partial class fTTinNhanSu : Form
    {
        private string manv = "";
        public static string State = "-1";
        DataTable dtable;
        string[] madv = new string[] { "1", "2", "3", "4", "5", "6", "7" };
        string[] phai = new string[] { "Nam", "Nu" };
        string[] vaitro = new string[] { "NVCB", "GIANGVIEN", "GIAOVU", "TRUONGDONVI", "TRUONGKHOA" };
        public fTTinNhanSu(string manv)
        {
            this.manv = manv;
            InitializeComponent();
            fTTinNhanSu_Load(null, null);
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            foreach (string col in madv)
            {
                cbBoxMadv.Items.Add(col);
            }
            foreach (string col in phai)
            {
                cbBoxPhai.Items.Add(col);
            }
            foreach (string col in vaitro)
            {
                cbBoxVaitro.Items.Add(col);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void fTTinNhanSu_Load(object sender, EventArgs e)
        {
            // nếu không có manv => thêm mới nhân viên
            if (string.IsNullOrEmpty(manv))
            {
                this.Text = "Thêm mới nhân viên";
                State = "Insert";
                mtbNgaySinh.Visible = true;
                txtNgaySinh.Visible = false;
                txtUsername.Visible = false; 
            }
            else
            {
                this.Text = "Cập nhật nhân viên";
                State = "Update";
                this.mtbNgaySinh.Visible = false;
                this.txtNgaySinh.Visible = true;
                txtUsername.Enabled = false;

                // Lấy thông tin chi tiết của 1 NV dựa vào mã nv
                // manv được truyền từ form fNhanSu
                string sql = "select * from U_ADMIN.NHANSU where MANV = " + manv;
                dtable = Database.GetDataToTable(sql);
                if (dtable.Rows.Count > 0)
                {
                    // Set các giá trị vào component của form
                    txtHoTen.Text = dtable.Rows[0]["HOTEN"].ToString();
                    /*mtbNgaySinh.Text = dtable.Rows[0]["NGSINH"].ToString();*/
                    txtNgaySinh.Text = Database.ChuyenDoiNgaySinh(dtable.Rows[0]["NGSINH"].ToString());
                    cbBoxPhai.Text = dtable.Rows[0]["PHAI"].ToString();
                    txtSdt.Text = dtable.Rows[0]["DT"].ToString();

                    cbBoxMadv.Text = dtable.Rows[0]["MADV"].ToString();
                    cbBoxVaitro.Text = dtable.Rows[0]["VAITRO"].ToString();
                    txtPhucap.Text = dtable.Rows[0]["PHUCAP"].ToString();
                    txtUsername.Text = dtable.Rows[0]["USERNAME"].ToString();

                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string hoTen = txtHoTen.Text;
            string ngaySinh = Database.ChuyenDoiNgaySinh(txtNgaySinh.Text);
            string mtb_ngaySinh = mtbNgaySinh.Text;
            string phai = cbBoxPhai.Text;
            string sdt = txtSdt.Text;
            string madv = cbBoxMadv.Text;
            string vaitro = cbBoxVaitro.Text;
            string phucap = txtPhucap.Text;
            string user_name = txtUsername.Text;

            if (State == "Insert")
            {
                sql = "INSERT INTO U_ADMIN.NHANSU (HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) " +
                      $"VALUES ('{hoTen}', '{phai}', TO_DATE('{mtb_ngaySinh}', 'DD-MM-YYYY'), " +
                      $"'{phucap}', '{sdt}', '{vaitro}', '{madv}')";
            }
            else if (State == "Update")
            {
                sql = $"UPDATE U_ADMIN.NHANSU SET HOTEN = '{hoTen}', PHAI = '{phai}', " +
                      $"NGSINH = TO_DATE('{ngaySinh}', 'DD-MM-YYYY'), PHUCAP = '{phucap}', " +
                      $"DT = '{sdt}', VAITRO = '{vaitro}', MADV = '{madv}' " +
                      $"WHERE MANV = '{manv}'";
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
