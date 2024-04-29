using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLDuLieuNoiBo
{
    public partial class fUsers : Form
    {
        #region Variable
        string strCon = @"DATA SOURCE=localhost:1521/PDBQLDLNB; USER ID=U_ADMIN;PASSWORD=123;";
        string pdb = "PDBQLDLNB";
        string host_name = "localhost:1521/PDBQLDLNB";
        OracleConnection con;
        public static string State = "-1";
        string username = "";
        string password = "";

        string dbUser = "SYS";
        //string dbUser_password = "21127659";
        string dbUser_password = "21127495";

<<<<<<< HEAD:GUI/QLDuLieuNoiBo/QLDuLieuNoiBo/Admin/fUsers.cs
        bool sys = false;
=======
        bool sys = true;
>>>>>>> d2bd337147d6ab70f410a77f21fa8087d80b61e7:GUI/QLDuLieuNoiBo/QLDuLieuNoiBo/fUsers.cs
        #endregion
        public fUsers()
        {
            InitializeComponent();
            fUsers_Load(null,null);
            GetData();
            SetControl("Reset");
        }

        #region Public Function


        private void fUsers_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(strCon);

            // Tạo một đối tượng kết nối
            using (OracleConnection con = new OracleConnection(strCon))
            {
                try
                {
                    // Mở kết nối
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
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
                    btnRecord.Enabled = false;
                    btnCancel.Enabled = false;

                    lblPassword.Enabled = true;
                    txtUId.Enabled = true;
                    txtPassword.Enabled = false;
                    
                    txtUId.Text = "";
                    txtUName.Text = "";
                    txtPassword.Text = "";

                    radBtnLock.Hide();
                    radBtnUnlock.Hide();
                    radBtnCascade.Hide();

                    radBtnLock.Checked = false;
                    radBtnUnlock.Checked = false;
                    radBtnCascade.Checked = false;
                    break;
                default:
                    break;
            }
        }

        public void GetData()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

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
            lblAction.Text = "Thêm";
            lblAction.Visible = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
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
            lblAction.Text = "Sửa";
            lblAction.Visible = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnRecord.Enabled = true;
            btnCancel.Enabled = true;

            lblPassword.Enabled = true;
            txtUId.Enabled = false;
            txtPassword.Enabled = true;
/*            txtUId.Text = "";
            txtUName.Text = "";*/
            txtPassword.Text = "";

            radBtnLock.Show();
            radBtnUnlock.Show();

            State = "Update";
            txtUName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblAction.Text = "Xóa";
            lblAction.Visible = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnRecord.Enabled = true;
            btnCancel.Enabled = true;

            lblPassword.Enabled = true;
            txtUId.Enabled = false;
            txtPassword.Enabled = false;
            txtUId.Text = "";
            txtUName.Text = "";
            txtPassword.Text = "";

            radBtnCascade.Show();

            State = "Delete";
            txtUName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetControl("Reset");
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
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    string username = txtUName.Text.Trim().ToUpper();
/*                    string sqlCheckUser = "SELECT COUNT(*) FROM DBA_USERS WHERE USERNAME = '" + username + "'";
                    Console.WriteLine(sqlCheckUser);
                    OracleCommand cmdCheckUser = new OracleCommand(sqlCheckUser, con);

                    cmdCheckUser.Parameters.Add("USERNAME", OracleDbType.Varchar2).Value = "SYS";

                    int count = Convert.ToInt32(cmdCheckUser.ExecuteScalar());
*//*                    if ((Database.isUserValid(username) == 1))
                    {
                        MessageBox.Show("Tên người dùng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }*/

                    /*OracleCommand setTrue = con.CreateCommand();
                    setTrue.CommandText = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = TRUE";
                    setTrue.ExecuteNonQuery();
*/
                    // Nếu username chưa tồn tại, thực hiện tạo mới
                    password = txtPassword.Text.Trim();
                    OracleCommand insertCRUD = con.CreateCommand();
                    insertCRUD.CommandText = "CREATE USER " + username + " IDENTIFIED BY " + password + " CONTAINER = CURRENT";
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
/*                    OracleCommand setFalse = con.CreateCommand();
                    setFalse.CommandText = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = FALSE";
                    setFalse.ExecuteNonQuery();*/

                    lblAction.Visible = false;
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
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
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    if (radBtnLock.Checked == false && radBtnUnlock.Checked == false)
                    {
                        MessageBox.Show("Vui lòng chọn Lock hoặc Unlock account!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Kiểm tra xem username đã tồn tại chưa
                    string username = txtUName.Text.Trim().ToUpper();
                    string sqlCheckUser = "SELECT COUNT(*) FROM DBA_USERS WHERE USERNAME = '" + username + "'";
                    OracleCommand cmdCheckUser = new OracleCommand(sqlCheckUser, con);
                    int count = Convert.ToInt32(cmdCheckUser.ExecuteScalar());
                    if (count == 0)
                    {
                        MessageBox.Show("Người dùng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Thực hiện cập nhật mật khẩu cho người dùng
                    string newPassword = txtPassword.Text.Trim();
                    string sql = "";

                    if (radBtnLock.Checked == true)
                    {
                        sql = "ALTER USER " + username + " IDENTIFIED BY " + newPassword + " ACCOUNT LOCK";
                    }
                    if (radBtnUnlock.Checked == true)
                    {
                        sql = "ALTER USER " + username + " IDENTIFIED BY " + newPassword + " ACCOUNT UNLOCK";
                    }

                    OracleCommand updateCRUD = con.CreateCommand();
                    updateCRUD.CommandText = sql;
                    int rowsUpdated = updateCRUD.ExecuteNonQuery();
                    if (rowsUpdated != 0)
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Console.WriteLine("Cập nhật mật khẩu thành công!");
                        GetData();
                        SetControl("Reset"); // Làm mới dữ liệu sau khi xóa
                        txtUName.Text = "";
                        txtPassword.Text = "";

                        lblAction.Visible = false;
                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                        txtUId.Enabled = true;

/*                        OracleCommand setFalse = con.CreateCommand();
                        setFalse.CommandText = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = FALSE";
                        setFalse.ExecuteNonQuery();*/
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
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

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
                    if (radBtnCascade.Checked)
                    {
                        sqlDeleteUser += " CASCADE";
                    }

/*                    OracleCommand setTrue = con.CreateCommand();
                    setTrue.CommandText = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = TRUE";
                    setTrue.ExecuteNonQuery();*/

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

        private void revokePrivilegesRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fRevokeRoles _fRevokeRoles = new fRevokeRoles();
            _fRevokeRoles.Show();
            this.Hide();
        }

        private void grantRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGrantRoles _fGrantRoles = new fGrantRoles();
            _fGrantRoles.Show();
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

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAddRole _fAddRole = new fAddRole();
            _fAddRole.Show();
            this.Hide();
        }

        private void colPrivilegesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fColumnPriv _fColumnPriv = new fColumnPriv();
            _fColumnPriv.Show();
            this.Hide();
<<<<<<< HEAD:GUI/QLDuLieuNoiBo/QLDuLieuNoiBo/Admin/fUsers.cs
        }

        private void dataGridView_ListUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView_ListUsers.Rows[index];
            Console.WriteLine(selectedRow);
            if (selectedRow != null)
            {
                txtUId.Text = selectedRow.Cells["USER_ID"].Value.ToString();
                txtUName.Text = selectedRow.Cells["USERNAME"].Value.ToString();
            }
=======
>>>>>>> d2bd337147d6ab70f410a77f21fa8087d80b61e7:GUI/QLDuLieuNoiBo/QLDuLieuNoiBo/fUsers.cs
        }
    }
}
