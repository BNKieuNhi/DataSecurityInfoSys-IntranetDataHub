using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLDuLieuNoiBo
{
    public partial class fAddRole : Form
    {
        #region Variable
        OracleConnection _con;
        public static string State = "-1";
        //string username = "";
        //string password = "";

        string dbUser = "U_ADMIN";
        string dbUser_password = "123";
        bool sys = false;

        #endregion
        public fAddRole()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUsers _fUser = new fUsers();
            _fUser.Show();
            this.Hide();
        }

        private void columnPrivilegesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fColumnPriv _fColumnPriv = new fColumnPriv();
            _fColumnPriv.Show();
            this.Hide();
        }

        #region Public Function
        private void fAddRole_Load(object sender, EventArgs e)
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
            
            _con = new OracleConnection(conStr);

            _con.Open();
            OracleCommand query = _con.CreateCommand();

            //query.CommandType = CommandType.StoredProcedure;
            //SELECT* FROM USER_TAB_PRIVS

            //OracleCommand query = _con.CreateCommand();
            query.CommandText = "SELECT * FROM DBA_ROLES";

            query.CommandType = CommandType.Text;

            OracleDataReader dr = query.ExecuteReader();
            try
            {
                DataTable dt = new DataTable();
                dt.Load(dr);

                dataGridView1.DataSource = dt.DefaultView;
                dataGridView1.ReadOnly = true;

            }
            finally
            {
                dr.Close();
                _con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối
                _con.Open();

                string keyword = txtKeyword.Text.Trim();
                OracleCommand selectCRUD = _con.CreateCommand();
                selectCRUD.CommandText = "SELECT * FROM DBA_ROLES WHERE ROLE LIKE '%" + keyword + "%'";
                selectCRUD.CommandType = CommandType.Text;
                OracleDataReader dr = selectCRUD.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                _con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _con.Close();
                throw;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtIDRole.Enabled = false;

            txtTenRole.Focus();
            State = "Insert";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtIDRole.Enabled = false;

            txtTenRole.Focus();
            State = "Edit";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtIDRole.Enabled = false;

            txtTenRole.Focus();
            State = "Delete";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            if (selectedRow != null)
            {
                txtIDRole.Text = selectedRow.Cells["ROLE_ID"].Value.ToString();
                txtTenRole.Text = selectedRow.Cells["ROLE"].Value.ToString();
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (txtTenRole.Text.Trim().Length == 0) //||
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
                    _con.Open();

                    // Kiểm tra xem rolename đã tồn tại chưa
                    string rolename = txtTenRole.Text.Trim().ToUpper();
                    string sqlCheckRole = "SELECT COUNT(*) FROM DBA_ROLES WHERE ROLE = '" + rolename + "'";
                    Console.WriteLine(sqlCheckRole);
                    OracleCommand cmdCheckRole = new OracleCommand(sqlCheckRole, _con);
                    //cmdCheckRole.Parameters.Add("ROLE", OracleDbType.Varchar2, 50).Value = rolename;
                    int count = Convert.ToInt32(cmdCheckRole.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Tên Role đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Nếu rolename chưa tồn tại, thực hiện tạo mới
                    OracleCommand setTrue = _con.CreateCommand();
                    setTrue.CommandText = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = TRUE";
                    setTrue.ExecuteNonQuery();

                    OracleCommand insertCRUD = _con.CreateCommand();
                    insertCRUD.CommandText = "CREATE ROLE " + rolename;
                    int rows = insertCRUD.ExecuteNonQuery();
                    if (rows != 0)
                    {
                        MessageBox.Show("Data Inserted Successfully!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Console.WriteLine("Data Inserted Successfully!");

                        fAddRole_Load(sender, e);

                        txtTenRole.Text = "";
                    }

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = false;
                    txtIDRole.Enabled = true;

                    _con.Close();

                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _con.Close();
                }
            }
            /*
            if (State == "Edit")
            {
                // Tạo một đối tượng kết nối
                try
                {
                    // Mở kết nối
                    _con.Open();

                    // Kiểm tra xem rolename đã tồn tại chưa
                    string rolename = txtTenRole.Text.Trim().ToUpper();
                    string sqlCheckRole = "SELECT COUNT(*) FROM DBA_ROLES WHERE ROLE = '" + rolename + "'";
                    Console.WriteLine(sqlCheckRole);
                    OracleCommand cmdCheckRole = new OracleCommand(sqlCheckRole, _con);
                    //cmdCheckRole.Parameters.Add("ROLE", OracleDbType.Varchar2, 50).Value = rolename;
                    int count = Convert.ToInt32(cmdCheckRole.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Tên Role đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Nếu rolename chưa tồn tại, thực hiện tạo mới
                    OracleCommand setTrue = _con.CreateCommand();
                    setTrue.CommandText = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = TRUE";
                    setTrue.ExecuteNonQuery();

                    OracleCommand insertCRUD = _con.CreateCommand();
                    insertCRUD.CommandText = "CREATE ROLE " + rolename;
                    int rows = insertCRUD.ExecuteNonQuery();
                    if (rows != 0)
                    {
                        MessageBox.Show("Data Inserted Successfully!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Console.WriteLine("Data Inserted Successfully!");
                        txtTenRole.Text = "";
                    }

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    txtIDRole.Enabled = true;

                    _con.Close();

                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _con.Close();
                }
            }*/

            if (State == "Delete")
            {
                // Tạo một đối tượng kết nối
                try
                {
                    // Mở kết nối
                    _con.Open();

                    // Nếu rolename chưa tồn tại, thực hiện tạo mới
                    string rolename = txtTenRole.Text.Trim().ToUpper();
                    OracleCommand setTrue = _con.CreateCommand();
                    setTrue.CommandText = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = TRUE";
                    setTrue.ExecuteNonQuery();

                    OracleCommand deleteCRUD = _con.CreateCommand();
                    deleteCRUD.CommandText = "DROP ROLE " + rolename;
                    int rows = deleteCRUD.ExecuteNonQuery();
                    if (rows != 0)
                    {
                        MessageBox.Show("Data Deleted Successfully!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Console.WriteLine("Data Deleted Successfully!");

                        fAddRole_Load(sender, e);

                        txtTenRole.Text = "";
                        txtIDRole.Text= "";
                    }

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = false;
                    txtIDRole.Enabled = true;   
                    txtTenRole.Enabled = true;

                    _con.Close();

                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _con.Close();
                }
            }
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = false;

            txtIDRole.Enabled = true;
            txtTenRole.Enabled = true;
        }
    }
}

