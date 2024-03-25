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

        string dbUser = "SYS";
        string dbUser_password = "21127495";
        bool sys = true;
        #endregion
        public fUsers()
        {
            InitializeComponent();
            //fUsers_Load();
            GetData();
            SetControl("Reset");
        }

        #region Public Function


        private void fUsers_Load(object sender, EventArgs e)
        {
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

        public void SetControl(string State)
        {
            switch (State)
            {
                case "Reset":
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    btnView.Enabled = true;
                    btnRecord.Enabled = false;
                    btnCancel.Enabled = false;

                    lblPassword.Enabled = true;
                    txtUId.Enabled = true;
                    txtPassword.Enabled = false;

                    txtUId.Text = "";
                    txtUName.Text = "";
                    txtPassword.Text = "";
                    break;
                default:
                    break;
            }
        }

        public void GetData()
        {
            string conStr = "DATA SOURCE = localhost:1521/XE; DBA PRIVILEGE=SYSDBA; USER ID=" + dbUser + ";PASSWORD=" + dbUser_password;
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
                dataGridView_ListUsers.ReadOnly = true;
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ nếu có
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
            }

            lblPassword.Enabled = false;
            txtPassword.Enabled = false;
            btnRecord.Enabled = false;
            btnCancel.Enabled = false;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string conStr = "DATA SOURCE = localhost:1521/XE; DBA PRIVILEGE=SYSDBA; USER ID=" + dbUser + ";PASSWORD=" + dbUser_password;
                con = new OracleConnection(conStr);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string keyword = txtKeyword.Text.Trim();
                OracleCommand selectCRUD = con.CreateCommand();
                selectCRUD.CommandText = "SELECT USERNAME, USER_ID, ACCOUNT_STATUS, CREATED  FROM DBA_USERS WHERE ACCOUNT_STATUS = 'OPEN' AND USERNAME LIKE '%" + keyword + "%' ORDER BY CREATED DESC";
                selectCRUD.CommandType = CommandType.Text;
                OracleDataReader empDR = selectCRUD.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(empDR);
                dataGridView_ListUsers.DataSource = empDT;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnView.Enabled = true;
            btnRecord.Enabled = true;
            btnCancel.Enabled = true;

            lblPassword.Enabled = true;
            txtUId.Enabled = false;
            txtPassword.Enabled = true;
            txtUId.Text = "";
            txtUName.Text = "";
            txtPassword.Text = "";

            State = "Insert";
            txtUName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnView.Enabled = true;
            btnRecord.Enabled = true;
            btnCancel.Enabled = true;

            lblPassword.Enabled = true;
            txtUId.Enabled = false;
            txtPassword.Enabled = true;
            txtUId.Text = "";
            txtUName.Text = "";
            txtPassword.Text = "";

            State = "Update";
            txtUName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnView.Enabled = false;
            btnRecord.Enabled = true;
            btnCancel.Enabled = true;

            lblPassword.Enabled = true;
            txtUId.Enabled = false;
            txtPassword.Enabled = false;
            txtUId.Text = "";
            txtUName.Text = "";
            txtPassword.Text = "";

            State = "Delete";
            txtUName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetControl("Reset");
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


        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (State != "Delete")
            {
                if (txtUName.Text.Trim().Length == 0 ||
                    txtPassword.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (txtUName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Username!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    string sqlCheckUser = "SELECT COUNT(*) FROM DBA_USERS WHERE USERNAME = '" + username + "'";
                    Console.WriteLine(sqlCheckUser);
                    OracleCommand cmdCheckUser = new OracleCommand(sqlCheckUser, con);

                    cmdCheckUser.Parameters.Add("USERNAME", OracleDbType.Varchar2).Value = "SYS";

                    int count = Convert.ToInt32(cmdCheckUser.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Tên người dùng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    OracleCommand setTrue = con.CreateCommand();
                    setTrue.CommandText = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = TRUE";
                    setTrue.ExecuteNonQuery();

                    // Nếu username chưa tồn tại, thực hiện tạo mới
                    password = txtPassword.Text.Trim();
                    OracleCommand insertCRUD = con.CreateCommand();
                    insertCRUD.CommandText = "CREATE USER " + username + " IDENTIFIED BY " + password;
                    Console.WriteLine(insertCRUD.CommandText);

                    int rows = insertCRUD.ExecuteNonQuery();
                    Console.WriteLine(rows);

                    if (rows != 0)
                    {
                        MessageBox.Show("Data Inserted Successfully!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Console.WriteLine("Data Inserted Successfully!");
                        GetData();
                        SetControl("Reset"); // Làm mới dữ liệu sau khi them
                        txtUName.Text = "";
                        txtPassword.Text = "";
                    }
                    OracleCommand setFalse = con.CreateCommand();
                    setFalse.CommandText = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = FALSE";
                    setFalse.ExecuteNonQuery();

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
                finally
                {
                    con.Close();
                }
            }

            if (State == "Update")
            {
                try
                {
                    // Mở kết nối
                    con.Open();

                    // Kiểm tra xem username đã tồn tại chưa
                    string username = txtUName.Text.Trim().ToUpper();
                    string sqlCheckUser = "SELECT COUNT(*) FROM DBA_USERS WHERE USERNAME = '" + username + "'";
                    Console.WriteLine(sqlCheckUser);
                    OracleCommand cmdCheckUser = new OracleCommand(sqlCheckUser, con);
                    int count = Convert.ToInt32(cmdCheckUser.ExecuteScalar());
                    if (count == 0)
                    {
                        MessageBox.Show("Người dùng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Thực hiện cập nhật mật khẩu cho người dùng
                    string newPassword = txtPassword.Text.Trim();
                    OracleCommand updateCRUD = con.CreateCommand();
                    updateCRUD.CommandText = "ALTER USER " + username + " IDENTIFIED BY " + newPassword;
                    int rowsUpdated = updateCRUD.ExecuteNonQuery();
                    if (rowsUpdated != 0)
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Console.WriteLine("Cập nhật mật khẩu thành công!");
                        GetData();
                        SetControl("Reset"); // Làm mới dữ liệu sau khi xóa
                        txtUName.Text = "";
                        txtPassword.Text = "";

                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                        btnView.Enabled = true;
                        txtUId.Enabled = true;

                        OracleCommand setFalse = con.CreateCommand();
                        setFalse.CommandText = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = FALSE";
                        setFalse.ExecuteNonQuery();

                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                        btnView.Enabled = true;
                        txtUId.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mật khẩu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("Cập nhật mật khẩu không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }

            if (State == "Delete")
            {
                try
                {
                    // Mở kết nối
                    con.Open();

                    // Lấy tên người dùng từ textbox và chuẩn hóa thành chữ hoa
                    string username = txtUName.Text.Trim().ToUpper();

                    // Kiểm tra xem người dùng có tồn tại không
                    string sqlCheckUser = "SELECT COUNT(*) FROM DBA_USERS WHERE USERNAME = '" + username + "'";
                    OracleCommand cmdCheckUser = new OracleCommand(sqlCheckUser, con);
                    int count = Convert.ToInt32(cmdCheckUser.ExecuteScalar());
                    if (count == 0)
                    {
                        MessageBox.Show("Người dùng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Tạo câu lệnh SQL để xóa người dùng
                    string sqlDeleteUser = "DROP USER " + username;
                    //if (chkCascade.Checked)
                    {
                        sqlDeleteUser += " CASCADE";
                    }

                    OracleCommand setTrue = con.CreateCommand();
                    setTrue.CommandText = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = TRUE";
                    setTrue.ExecuteNonQuery();

                    // Thực hiện xóa người dùng
                    OracleCommand deleteCRUD = new OracleCommand(sqlDeleteUser, con);
                    int rowsDeleted = deleteCRUD.ExecuteNonQuery();
                    if (rowsDeleted != 0)
                    {
                        MessageBox.Show("Xóa người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Console.WriteLine("Xóa người dùng thành công!");
                        GetData();
                        SetControl("Reset"); // Làm mới dữ liệu sau khi xóa
                        txtUName.Text = "";
                        txtPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa người dùng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("Xóa người dùng không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close(); // Đảm bảo đóng kết nối sau khi thực hiện xong
                }
            }
        }
        #endregion
        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAddRole _fAddRole = new fAddRole();
            _fAddRole.Show();
            this.Hide();
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

        private void grantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGrantPrivileges _fGrantPrivileges = new fGrantPrivileges();
            _fGrantPrivileges.Show();
            this.Hide();
        }

        private void grantRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGrantRoles _fGrantRoles = new fGrantRoles();
            _fGrantRoles.Show();
            this.Hide();
        }

        private void colPrivilege_Click(object sender, EventArgs e)
        {
            fColumnPriv _fColumnPriv = new fColumnPriv();
            _fColumnPriv.Show();
            this.Hide();
        }

        private void revokePrivilegesRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fRevokeRoles _fRevokeRoles = new fRevokeRoles();
            _fRevokeRoles.Show();
            this.Hide();
        }

        private void usersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void roleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fAddRole _fAddRole = new fAddRole();
            _fAddRole.Show();
            this.Hide();
        }

        private void checkPrivilegesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fCheckPrivileges _fCheckPrivileges = new fCheckPrivileges();
            _fCheckPrivileges.Show();
            this.Hide();
        }

        private void grantToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fGrantPrivileges _fGrantPrivileges = new fGrantPrivileges();
            _fGrantPrivileges.Show();
            this.Hide();
        }

        private void grantRolesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fGrantRoles _fGrantRoles = new fGrantRoles();
            _fGrantRoles.Show();
            this.Hide();
        }

        private void revokePrivilegesRoleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fRevokeRoles _fRevokeRoles = new fRevokeRoles();
            _fRevokeRoles.Show();
            this.Hide();
        }

        private void colPrivilegesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fColumnPriv _fColumnPriv = new fColumnPriv();
            _fColumnPriv.Show();
            this.Hide();
        }
    }
}