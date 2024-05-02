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
    public partial class fTTHocPhan : Form
    {
        private string mahp = "";
        public fTTHocPhan(string mahp)
        {
            this.mahp = mahp;
            InitializeComponent();
            fTTHocPhan_Load(null, null);
            LoadComboBox();
            txtTenHP.Focus();
        }
        private void LoadComboBox()
        {
            // Tham khảo fTTSinhVien
        }
         
        private void fTTHocPhan_Load(object sender, EventArgs e)
        {
            // Xử lý
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Xử lý
            try
            {
                // 2. Prepare the SQL INSERT statement
                string tenHP = txtTenHP.Text; // Get the name of the course from the TextBox
                int soTC = Convert.ToInt32(txtSoTC.Text); // Convert the decimal value to an integer
                int stlt = Convert.ToInt32(textBox1.Text); // Convert the decimal value to an integer
                int stth = Convert.ToInt32(txtSoTietTH.Text); // Convert the decimal value to an integer
                int soSVTD = Convert.ToInt32(txtSoSVToiDa.Text); // Convert the decimal value to an integer
                //int maDV = (int)cbBoxMaDV.SelectedValue; // Get the selected department ID from the ComboBox

               
                // Check if the selected value is not null before attempting to convert
                int maDV = (cbBoxMaDV.SelectedItem != null) ? Convert.ToInt32(cbBoxMaDV.SelectedValue) : -1;
                
                
                string sql = $"INSERT INTO U_ADMIN.HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES " +
                             $"('{tenHP}', {soTC}, {stlt}, {stth}, {soSVTD}, {maDV})";

                // 3. Execute the INSERT statement
                int rowsAffected = new Database().Execute(sql);

                // Check if the insertion was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm mới học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Optionally, you can reset the input fields after successful insertion
                    txtTenHP.Text = "";
                    txtSoTC.Text = "";
                    textBox1.Text = "";
                    txtSoTietTH.Text = "";
                    txtSoSVToiDa.Text = "";

       
                    cbBoxMaDV.Text = ""; // Reset ComboBox selection
                }
                else
                {
                    MessageBox.Show("Thêm mới học phần thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xử lý
        }

        private void txtTenHP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoTietTH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoSVToiDa_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBoxMaDV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
