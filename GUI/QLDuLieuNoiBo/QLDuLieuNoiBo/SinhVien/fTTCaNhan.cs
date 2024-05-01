using QLDuLieuNoiBo.GiangVien;
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

namespace QLDuLieuNoiBo.SinhVien
{
    public partial class fTTCaNhan : Form
    {
        DataTable dtable;
        public fTTCaNhan()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            string sql = "select * from U_ADMIN.SINHVIEN";
            dtable = Database.GetDataToTable(sql);
            if (dtable.Rows.Count > 0)
            {

                txtUName.Text = dtable.Rows[0]["USERNAME"].ToString();
                txtHoTen.Text = dtable.Rows[0]["HOTEN"].ToString();
                txtNgaySinh.Text = Database.ChuyenDoiNgaySinh(dtable.Rows[0]["NGSINH"].ToString());
                txtPhai.Text = dtable.Rows[0]["PHAI"].ToString();
                textDTBTL.Text = dtable.Rows[0]["DTBTL"].ToString();
                txtSoTC.Text = dtable.Rows[0]["SOTCTL"].ToString();
                txtSdt.Text = dtable.Rows[0]["DT"].ToString();
                txtDChi.Text = dtable.Rows[0]["DChi"].ToString();
            }
        }

        private void fTTCaNhan_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string sdt = txtSdt.Text;
            string DChi = txtDChi.Text;
            string UName = txtUName.Text;
            // Thực hiện cập nhật số điện thoại
            string sql =
               "UPDATE U_ADMIN.SINHVIEN \n" +
               " SET " +
                "DT = '" + sdt + "', " +
                "DCHI = '" + DChi + 
                 "' WHERE USERNAME  = '" + UName + "' \n";

            var res = new Database().Execute(sql);
            Console.WriteLine(res);
            if (res == 1)
            {
                Database.ExeCute("COMMIT");
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
