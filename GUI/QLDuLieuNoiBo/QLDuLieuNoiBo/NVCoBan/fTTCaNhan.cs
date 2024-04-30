using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDuLieuNoiBo.NVCoBan
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
            string sql = "select * from U_ADMIN.V_XEMTTINCANHAN_NHANSU";
            dtable = Database.GetDataToTable(sql);
            if (dtable.Rows.Count > 0)
            {
                txtHoTen.Text = dtable.Rows[0]["HOTEN"].ToString();
                txtNgaySinh.Text = Database.ChuyenDoiNgaySinh(dtable.Rows[0]["NGSINH"].ToString());
                txtPhai.Text = dtable.Rows[0]["PHAI"].ToString();
                txtPhuCap.Text = dtable.Rows[0]["PHUCAP"].ToString();
                txtDonVi.Text = dtable.Rows[0]["MADV"].ToString();
                txtSdt.Text = dtable.Rows[0]["DT"].ToString();
            }
        }

        private void fTTCaNhan_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string sdt = txtSdt.Text;

            // Thực hiện cập nhật số điện thoại
            string sql = 
            "UPDATE U_ADMIN.V_XEMTTINCANHAN_NHANSU SET " +
            "DT = '" + sdt + "'";

            var res = new Database().Execute(sql);
            if (res == 1)
            {
                Database.ExeCute("COMMIT");
                MessageBox.Show("Cập nhật số điện thoại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
            }
            else
            {
                MessageBox.Show("Cập nhật số điện thoại thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
