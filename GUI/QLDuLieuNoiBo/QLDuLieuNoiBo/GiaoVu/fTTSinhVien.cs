using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QLDuLieuNoiBo.GiangVien
{
    public partial class fTTSinhVien : Form
    {
        private string masv = "";
        public static string State = "-1";
        DataTable dtable;
        public fTTSinhVien(string masv)
        {
            this.masv = masv;
            InitializeComponent();
            fTTSinhVien_Load(null, null);
        }

        private void fTTSinhVien_Load(object sender, EventArgs e)
        {
            // nếu không có masv => thêm mới sinh viên
            if (string.IsNullOrEmpty(masv))
            {
                this.Text = "Thêm mới sinh viên";
                State = "Insert";
                mtbNgaySinh.Visible = true;
                txtNgaySinh.Visible = false;
            }
            else
            {
                this.Text = "Cập nhật sinh viên";
                State = "Update";
                this.mtbNgaySinh.Visible = false;
                this.txtNgaySinh.Visible = true;

                // Lấy thông tin chi tiết của 1 SV dựa vào mã sv
                // masv được truyền từ form fSinhVien
                string sql = "select * from U_ADMIN.SINHVIEN where MASV = " + masv;
                dtable = Database.GetDataToTable(sql);
                if (dtable.Rows.Count > 0)
                {
                    // Set các giá trị vào component của form
                    txtHoTen.Text = dtable.Rows[0]["HOTEN"].ToString();
                    /*mtbNgaySinh.Text = dtable.Rows[0]["NGSINH"].ToString();*/
                    txtNgaySinh.Text = dtable.Rows[0]["NGSINH"].ToString();
                    cbBoxPhai.Text = dtable.Rows[0]["PHAI"].ToString();
                    txtSdt.Text = dtable.Rows[0]["DT"].ToString();
                    txtDiaChi.Text = dtable.Rows[0]["DCHI"].ToString();

                    cbBoxChuongTrinh.Text = dtable.Rows[0]["MACT"].ToString();
                    cbBoxNganh.Text = dtable.Rows[0]["MANGANH"].ToString();
                    txtTCTL.Text = dtable.Rows[0]["SOTCTL"].ToString();
                    txtDTBTL.Text = dtable.Rows[0]["DTBTL"].ToString();

                }
            }
            /*
            DataTable all_HinhThuDT = new Database().SelectData("GetTenHinhThucDangTuyen", null);
            foreach (DataRow row in all_HinhThuDT.Rows)
            {
                cbbMaHT.Items.Add(row["TenHinhThuc"].ToString());
            }
            }*/
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string hoTen = txtHoTen.Text;
            string ngaySinh = txtNgaySinh.Text;
            string mtb_ngaySinh = mtbNgaySinh.Text;
            string phai = cbBoxPhai.Text;
            string sdt = txtSdt.Text;
            string diaChi = txtDiaChi.Text;
            string chuongTrinh = cbBoxChuongTrinh.Text;
            string maNganh = cbBoxNganh.Text;
            string TCTL = txtTCTL.Text;
            string DTBTL = txtDTBTL.Text;

            if (State == "Insert")
            {
                sql = "INSERT INTO U_ADMIN.SINHVIEN (HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) " +
                      $"VALUES ('{hoTen}', '{phai}', TO_DATE('{mtb_ngaySinh}', 'DD-MM-YYYY'), " +
                      $"'{diaChi}', '{sdt}', '{chuongTrinh}', '{maNganh}', {TCTL}, {DTBTL})";
            }
            else if (State == "Update")
            {
                sql = $"UPDATE U_ADMIN.SINHVIEN SET HOTEN = '{hoTen}', PHAI = '{phai}', " +
                      $"NGSINH = TO_DATE('{ngaySinh}', 'DD-MM-YYYY'), DCHI = '{diaChi}', " +
                      $"DT = '{sdt}', MACT = '{chuongTrinh}', MANGANH = '{maNganh}', " +
                      $"SOTCTL = {TCTL}, DTBTL = {DTBTL} WHERE MASV = '{masv}'";
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
