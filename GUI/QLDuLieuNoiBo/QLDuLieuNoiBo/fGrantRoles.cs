using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLDuLieuNoiBo
{
    public partial class fGrantRoles : Form
    {
        OracleConnection con;

        string username = "";
        string password = "";

        string dbUser = "SYS";
        //string dbUser_password = "21127495";
        string dbUser_password = "21127495";
        bool sys = true;
        public fGrantRoles()
        {
            InitializeComponent();
            string conStr = "";

            if (sys)
            {
                conStr = "DATA SOURCE = localhost:1521/XE; DBA PRIVILEGE=SYSDBA; USER ID=" + dbUser + ";PASSWORD=" + dbUser_password;
            }
            else
            {
                conStr = "DATA SOURCE = localhost:1521/XE; USER ID=" + dbUser + ";PASSWORD=" + dbUser_password;
            }

            con = new OracleConnection(conStr);
        }


        private void fGrantRoles_Load(object sender, EventArgs e)
        {
            con.Open();

            string[] cols = new string[] { "NHANVIENCOBAN", "TRUONGKHOA", "TRUONGDONVI",
                "GIAOVU", "GIANGVIEN","SINHVIEN"};

            foreach (string col in cols)
            {
                cbBox_Role.Items.Add(col);
            }


            con.Close();
        }
        public void GetData()
        {
            string conStr = "DATA SOURCE = localhost:1521/XE; DBA PRIVILEGE=SYSDBA; USER ID=" + dbUser + ";PASSWORD=" + dbUser_password;
            con = new OracleConnection(conStr);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string selectedRole = "";
                string whereClause = ""; // Điều kiện WHERE cho truy vấn SQL

                // Kiểm tra xem có mục nào được chọn trong combobox không
                if (cbBox_Role.SelectedItem != null)
                {
                    // Lấy giá trị của mục được chọn
                    selectedRole = cbBox_Role.SelectedItem.ToString();

                    // Tạo điều kiện WHERE để chỉ lấy dữ liệu của role được chọn
                    whereClause = "WHERE GRANTED_ROLE = '" + selectedRole + "'";


                    // Tạo câu truy vấn SQL
                    string sql = "SELECT * FROM DBA_ROLE_PRIVS " + whereClause;

                    OracleCommand selectCRUD = con.CreateCommand();
                    selectCRUD.CommandText = sql;

                    selectCRUD.CommandType = CommandType.Text;
                    OracleDataReader empDR = selectCRUD.ExecuteReader();
                    DataTable empDT = new DataTable();
                    empDT.Load(empDR);
                    dataGridView_ListUsers.DataSource = empDT;
                    dataGridView_ListUsers.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ nếu có
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
            }
        }

        private void revokePrivilegesRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fRevokeRoles _fRevokeRoles = new fRevokeRoles();
            _fRevokeRoles.Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbBox_Role.Text.Trim().Length == 0 || txtInput.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui long nhap day du du lieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            String role = cbBox_Role.Text.Trim().ToUpper();
            String input = txtInput.Text.Trim().ToUpper();
            string sqlCheck = "SELECT COUNT(*) FROM DBA_USERS WHERE USERNAME = '" + input + "'";
            Console.WriteLine(sqlCheck);
            OracleCommand cmdCheck = new OracleCommand(sqlCheck, con);

            int count = 0;
            count = Convert.ToInt32(cmdCheck.ExecuteScalar());

            sqlCheck = "SELECT COUNT(*) FROM DBA_ROLES WHERE ROLE = '" + input + "'";
            Console.WriteLine(sqlCheck);
            cmdCheck = new OracleCommand(sqlCheck, con);

            count += Convert.ToInt32(cmdCheck.ExecuteScalar());

            if (count <= 0)
            {
                MessageBox.Show("Khong tim thay nguoi dung/vai tro", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OracleCommand oc = con.CreateCommand();

            oc.CommandText = "GRANT " + role + " TO " + input;

            Console.WriteLine(oc.CommandText);

            int res = 0;
            res = oc.ExecuteNonQuery();

            if (res != 0)
            {
                MessageBox.Show("Cap nhat quyen thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                GetData();
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUsers _fUser = new fUsers();
            _fUser.Show();
            this.Hide();
        }

        private void checkPrivilegesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCheckPrivileges _fCheckPrivileges = new fCheckPrivileges();
            _fCheckPrivileges.Show();
            this.Hide();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAddRole _fAddRole = new fAddRole();
            _fAddRole.Show();
            this.Hide();
        }

        private void grantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGrantPrivileges _fGrantPrivileges = new fGrantPrivileges();
            _fGrantPrivileges.Show();
            this.Hide();
        }

        private void cbBox_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fColumnPriv _fColumnPriv = new fColumnPriv();
            _fColumnPriv.Show();
            this.Hide();
        }

        private void fGrantRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}