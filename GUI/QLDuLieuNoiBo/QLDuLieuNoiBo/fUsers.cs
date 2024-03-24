using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLDuLieuNoiBo
{
    public partial class fUsers : Form
    {
        #region Variable
        OracleConnection con;
        public static string State = "-1";
        string username = "";
        string password = "";
        #endregion
        public fUsers()
        {
            InitializeComponent();
            //fUsers_Load();
            GetData();
        }

        #region Public Function


        private void fUsers_Load(object sender, EventArgs e)
        {
            string conStr = "DATA SOURCE = localhost:1521/XE; USER ID=C##ADMIN;PASSWORD=123";
            con = new OracleConnection(conStr);

            // Tạo một đối tượng kết nối
            using (OracleConnection con = new OracleConnection(conStr))
            {
                try
                {
                    // Mở kết nối
                    con.Open();

                    // Kết nối thành công, bạn có thể thực hiện các thao tác với cơ sở dữ liệu ở đây

                    // Sau khi hoàn thành công việc, đóng kết nối
                    con.Close();
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    Console.WriteLine("Lỗi kết nối: " + ex.Message);
                }
            }
        }

        public void GetData()
        {
            string conStr = "DATA SOURCE = localhost:1521/XE; USER ID=C##ADMIN;PASSWORD=123";
            con = new OracleConnection(conStr);
            try
            {

            
                con.Open();
                OracleCommand selectCRUD = con.CreateCommand();
                selectCRUD.CommandText = "SELECT USERNAME, USER_ID, ACCOUNT_STATUS, CREATED  FROM DBA_USERS WHERE ACCOUNT_STATUS = 'OPEN' ORDER BY CREATED DESC";
                selectCRUD.CommandType = CommandType.Text;
                OracleDataReader empDR = selectCRUD.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(empDR);
                dataGridView_ListUsers.DataSource = empDT;
            }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    Console.WriteLine("Lỗi kết nối: " + ex.Message);
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnView.Enabled = true;
            txtUId.Enabled = false;

            txtUName.Text = "";
            txtPassword.Text = "";

            State = "Insert";
            txtUName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            /*
            btnView.Enabled = true;

            txtUName.Text = "";
            txtPassword.Text = "";

            con.Open();
            OracleCommand selectCRUD = con.CreateCommand();
            selectCRUD.CommandText = "SELECT USERNAME, USER_ID, ACCOUNT_STATUS, CREATED  FROM DBA_USERS WHERE ACCOUNT_STATUS = 'OPEN' ORDER BY CREATED DESC";
            selectCRUD.CommandType = CommandType.Text;
            OracleDataReader empDR = selectCRUD.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView_ListUsers.DataSource = empDT;
            con.Close();
            */
        }

        private void dataGridView_ListUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView_ListUsers.Rows[index];
            
            if (selectedRow != null)
            {
                txtUId.Text = selectedRow.Cells["USER_ID"].Value.ToString();
                txtUName.Text = selectedRow.Cells["USERNAME"].Value.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (txtUName.Text.Trim().Length == 0 ||
                txtPassword.Text.Trim().Length == 0) //||
                                                     //cbBox_vaitro.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (State == "Insert")
            {
                // Tạo một đối tượng kết nối
                try
                {
                    // Mở kết nối
                    con.Open();

                    // Kiểm tra xem username đã tồn tại chưa
                    string username = txtUName.Text.Trim().ToUpper();
                    string sqlCheckUser = "SELECT COUNT(*) FROM DBA_USERS WHERE USERNAME = " + username;
                    OracleCommand cmdCheckUser = new OracleCommand(sqlCheckUser, con);
                    cmdCheckUser.Parameters.Add("USERNAME", OracleDbType.Varchar2).Value = username;
                    int count = Convert.ToInt32(cmdCheckUser.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Tên người dùng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Nếu username chưa tồn tại, thực hiện tạo mới
                    password = txtPassword.Text.Trim();
                    OracleCommand insertCRUD = con.CreateCommand();
                    insertCRUD.CommandText = "CREATE USER " + username + " IDENTIFIED BY " + password;
                    int rows = insertCRUD.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Data Inserted Successfully!");
                        txtUName.Text = "";
                        txtPassword.Text = "";
                    }

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    btnView.Enabled = true;
                    txtUId.Enabled = true;

                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
