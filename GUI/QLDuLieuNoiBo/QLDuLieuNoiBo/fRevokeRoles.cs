using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLDuLieuNoiBo
{
    public partial class fRevokeRoles : Form
    {
        #region Variable
        public OracleConnection con;
        public static string State = "-1";

        string dbUser = "SYS";
        string dbUser_password = "21127659";
        bool sys = true;
        #endregion

        public fRevokeRoles()
        {
            InitializeComponent();
            Fill_comboBox();
            GetData();
        }
        public DataTable GetAllRoles()
        {
            string conStr = "DATA SOURCE = localhost:1521/XE; DBA PRIVILEGE=SYSDBA; USER ID=" + dbUser + ";PASSWORD=" + dbUser_password;
            con = new OracleConnection(conStr);

            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT ROLE, ROLE_ID " +
                "FROM USER_ROLE_PRIVS US JOIN DBA_ROLES DR ON DR.ROLE = US.GRANTED_ROLE " +
                "WHERE DR.ROLE <> 'CONNECT' AND DR.ROLE <> 'RESOURCE' AND DR.ROLE <> 'DBA'";
            command.Connection = con;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }
        public DataTable GetAllUsers_wasCreateByUser()
        {
            string conStr = "DATA SOURCE = localhost:1521/XE; DBA PRIVILEGE=SYSDBA; USER ID=" + dbUser + ";PASSWORD=" + dbUser_password;
            con = new OracleConnection(conStr);

            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM dba_users WHERE ACCOUNT_STATUS = 'OPEN' ORDER BY CREATED DESC";
            command.Connection = con;

            OracleDataAdapter adapter;
            DataTable dataTable;
            try
            {
                adapter = new OracleDataAdapter(command);
                dataTable = new DataTable(); //create a new table
                adapter.Fill(dataTable);
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }

            return dataTable;
        }

        private void Fill_comboBox()
        {
            // lấy tất cả role của username này
            DataTable all_role = GetAllRoles();
            foreach (DataRow row in all_role.Rows)
            {
                cbRole.Items.Add(row["ROLE"].ToString());
            }

            // lấy tất cả user của username này
            DataTable all_user = GetAllUsers_wasCreateByUser();
            foreach (DataRow row in all_user.Rows)
            {
                cbRoleUser.Items.Add(row["USERNAME"].ToString());
            }
        }

        public void GetData()
        {
            string conStr = "DATA SOURCE = localhost:1521/XE; DBA PRIVILEGE=SYSDBA; USER ID=" + dbUser + ";PASSWORD=" + dbUser_password;
            con = new OracleConnection(conStr);
            try
            {
                con.Open();

                string selectedRole = "";
                string whereClause = ""; // Điều kiện WHERE cho truy vấn SQL

                // Kiểm tra xem có mục nào được chọn trong combobox không
                if (cbRole.SelectedItem != null)
                {
                    // Lấy giá trị của mục được chọn
                    selectedRole = cbRole.SelectedItem.ToString();

                    // Tạo điều kiện WHERE để chỉ lấy dữ liệu của role được chọn
                    whereClause = "WHERE GRANTED_ROLE = '" + selectedRole + "'";
                }

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
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ nếu có
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
            }
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string conStr = "DATA SOURCE = localhost:1521/XE; DBA PRIVILEGE=SYSDBA; USER ID=" + dbUser + ";PASSWORD=" + dbUser_password;
            con = new OracleConnection(conStr);
            try
            {
                if (cbRoleUser.Text.Trim().Length == 0 || cbRole.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                String role = cbRole.Text.Trim().ToUpper();
                String user_OR_role = cbRoleUser.Text.Trim().ToUpper();

                if (!role.Equals(user_OR_role))
                {
                    String sql = "REVOKE " + role + " FROM " + user_OR_role;
                    try
                    {
                        // Mở kết nối
                        con.Open();
                        OracleCommand cmd = con.CreateCommand();
                        cmd.CommandText = sql;
                        Console.WriteLine(cmd.CommandText);

                        // Thực hiện lệnh SQL
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected != 0)
                        {
                            MessageBox.Show("Revoke thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Revoke thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        GetData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Đảm bảo đóng kết nối sau khi sử dụng xong
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ nếu có
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUsers _fUser = new fUsers();
            _fUser.Show();
            this.Hide();
        }
    }
}
