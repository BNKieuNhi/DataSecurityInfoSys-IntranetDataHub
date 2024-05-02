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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLDuLieuNoiBo.GiaoVu
{
    public partial class fPhanCong_GVU : Form
    {
        DataTable dtable;
        

        public fPhanCong_GVU()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            //Load table PHANCONG
            string sql = "select * from U_ADMIN.PHANCONG";
            dtable = Database.GetDataToTable(sql);

            dgvDSPhanCong.DataSource = dtable;

            //Load MaHP 
            LoadComboBox(); 

        }
        private void LoadComboBox()
        {
            string sqlHK = "SELECT DISTINCT HK FROM U_ADMIN.V_XEMPCVPKHOA";
            dtable = Database.GetDataToTable(sqlHK);

            // Assuming there's only one column in the DataTable
            foreach (DataRow row in dtable.Rows)
            {
                comboBox2.Items.Add(row["HK"].ToString());
            }

            string sqlMaCT = "SELECT DISTINCT MACT FROM U_ADMIN.V_XEMPCVPKHOA";
            dtable = Database.GetDataToTable(sqlMaCT);

            // Assuming there's only one column in the DataTable
            foreach (DataRow row in dtable.Rows)
            {
                comboBox1.Items.Add(row["MaCT"].ToString());
            }

        }



        private void UpdateData()
        {
            string MaGV_new = txt_MaGV.Text; // Lấy mã giáo viên từ textbox
            string MaHP_new = txt_MaHP.Text; // Lấy mã học phần từ textbox
            string HK_new = comboBox2.Text; // Lấy học kỳ từ textbox
            string Nam_new = txt_Nam.Text; // Lấy năm học từ textbox
            string MACT_new = comboBox1.Text; // Lấy học kì từ textbox

            string MaGV_old = textBox1.Text; // Lấy mã giáo viên cũ từ textbox
            string MaHP_old = textBox2.Text; // Lấy mã học phần cũ từ textbox
            string HK_old = textBox3.Text; // Lấy học kỳ cũ từ textbox
            string Nam_old = textBox4.Text; // Lấy năm học cũ từ textbox
            string MACT_old = textBox5.Text; // Lấy mã cán bộ cũ từ textbox


            // Xác định truy vấn SQL để cập nhật dữ liệu thông qua view
            /*string sqlUpdate = @"UPDATE U_ADMIN.V_XEMPCVPKHOA 
                         SET MAGV = MaGV_new,
                             MAHP = MaHP_new,
                             HK = HK_new,
                             NAM = Nam_new,
                             MACT =  MaCT_new WHERE 
                             MAGV = MaGV_old,
                             MAHP = MaHP_old,
                             HK = HK_old,
                             NAM = Nam_old,
                             MACT = MaCT_old";*/

            string sqlUpdate = $@"UPDATE U_ADMIN.V_XEMPCVPKHOA 
                     SET MAGV = '{MaGV_new}',
                         MAHP = '{MaHP_new}',
                         HK = '{HK_new}',
                         NAM = '{Nam_new}',
                         MACT = '{MACT_new}' 
                     WHERE MAGV = '{MaGV_old}'
                     AND MAHP = '{MaHP_old}'
                     AND HK = '{HK_old}'
                     AND NAM = '{Nam_old}'
                     AND MACT = '{MACT_old}'";



            // Thực hiện câu lệnh cập nhật thông qua view
            var rowsAffected = new Database().Execute(sqlUpdate);
           
            // Kiểm tra xem có bao nhiêu dòng đã bị ảnh hưởng
            if (rowsAffected > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công!");
                // Sau khi cập nhật, cần gọi lại phương thức GetData() để làm mới dữ liệu trên DataGridView
                GetData();
            }
            else
            {
                MessageBox.Show("Không có dòng nào được cập nhật.");
            }
        }

       
        private void fPhanCong_GVU_Load(object sender, EventArgs e)
        {
            //Display table PHANCONG 
            GetData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Sua_Click(object sender, EventArgs e)
        {
            //Display the data from selected rows which GVu can edit 
            string sql = "SELECT * FROM U_ADMIN.V_XEMPCVPKHOA";
            
            dtable = Database.GetDataToTable(sql);

            dgvDSPhanCong.DataSource = dtable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_MaGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDSPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvDSPhanCong.Rows[index];
            Console.WriteLine(selectedRow);
            if (selectedRow != null)
            {
                textBox1.Text = selectedRow.Cells["MAGV"].Value.ToString();
                textBox2.Text = selectedRow.Cells["MAHP"].Value.ToString();
                textBox3.Text = selectedRow.Cells["HK"].Value.ToString();
                textBox4.Text = selectedRow.Cells["NAM"].Value.ToString();
                textBox5.Text = selectedRow.Cells["MACT"].Value.ToString();


                txt_MaGV.Text = selectedRow.Cells["MAGV"].Value.ToString();
                txt_MaHP.Text = selectedRow.Cells["MAHP"].Value.ToString();
                comboBox2.Text = selectedRow.Cells["HK"].Value.ToString();
                txt_Nam.Text = selectedRow.Cells["NAM"].Value.ToString();
                comboBox1.Text = selectedRow.Cells["MACT"].Value.ToString();
            }
        }

        private void dgvDSPhanCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_MaHP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGhi_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e) //GHI 
        {
            UpdateData(); 
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txt_MaGV.Text = ""; // Lấy mã giáo viên từ textbox
            txt_MaHP.Text = ""; // Lấy mã học phần từ comboBox
            comboBox2.Text = ""; // Lấy học kỳ từ textbox
            txt_Nam.Text = ""; // Lấy năm học từ textbox
            comboBox1.Text = ""; // Lấy học kì từ textbox
            
           
            textBox1.Text = ""; // Lấy mã giáo viên cũ từ textbox
            textBox2.Text = ""; // Lấy mã học phần cũ từ textbox
            textBox3.Text = ""; // Lấy học kỳ cũ từ textbox
            textBox4.Text = ""; // Lấy năm học cũ từ textbox
            textBox5.Text = ""; // Lấy mã cán bộ cũ từ textbox

            GetData(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}



