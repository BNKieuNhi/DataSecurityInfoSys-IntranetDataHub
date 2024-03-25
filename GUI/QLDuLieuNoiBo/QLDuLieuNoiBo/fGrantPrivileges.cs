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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLDuLieuNoiBo
{
    public partial class fGrantPrivileges : Form
    {
        OracleConnection con;

        string dbUser = "SYS";
        string dbUser_password = "21127495";
        bool sys = true;

        DataTable pri_tables = new DataTable();
        DataTable allTables = new DataTable();
        string inputType = "";

        public fGrantPrivileges()
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

        private bool checkPrivileges(string input, string priv_name, string table_name, string grantable, string type)
        {
            OracleCommand oc = con.CreateCommand();

            if (type == "Role")
            {
                oc.CommandText = "SELECT COUNT(*) FROM ROLE_TAB_PRIVS " +
                "WHERE ROLE = '" + input
                + "' AND TABLE_NAME = '" + table_name
                + "' AND PRIVILEGE = '" + priv_name
                + "' AND GRANTABLE = '" + grantable + "'";
            }
            else
            {
                oc.CommandText = "SELECT COUNT(*) FROM DBA_TAB_PRIVS " +
                "WHERE GRANTEE = '" + input
                + "' AND TABLE_NAME = '" + table_name
                + "' AND PRIVILEGE = '" + priv_name
                + "' AND GRANTABLE = '" + grantable + "'";
            }
            oc.CommandType = CommandType.Text;
            Console.WriteLine(oc.CommandText);

            int count = 0;
            //Convert.ToInt32(cmdCheckUser.ExecuteScalar());
            count = Convert.ToInt32(oc.ExecuteScalar());
            if (count <= 0)
            {
                return false;
            }

            return true;
        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            if (txtInput.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhap ten user/roles", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //con.Close();
                return;
            }

            dataGridView_ListGrant.Rows.Clear();
            string input = txtInput.Text.Trim().ToUpper();
            string sqlCheck = "SELECT COUNT(*) FROM DBA_USERS WHERE USERNAME = '" + input + "'";
            //Console.WriteLine(sqlCheck);
            OracleCommand cmdCheck = new OracleCommand(sqlCheck, con);

            int count = 0;
            count = Convert.ToInt32(cmdCheck.ExecuteScalar());

            if (count > 0)
            {
                inputType = "User";
            }
            sqlCheck = "SELECT COUNT(*) FROM DBA_ROLES WHERE ROLE = '" + input + "'";
            //Console.WriteLine(sqlCheck);
            cmdCheck = new OracleCommand(sqlCheck, con);

            count += Convert.ToInt32(cmdCheck.ExecuteScalar());

            if (count <= 0)
            {
                MessageBox.Show("Khong tim thay nguoi dung/vai tro", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (inputType == "")
            {
                inputType = "Role";
            }

            OracleCommand oc = con.CreateCommand();
            oc.CommandText = "SELECT TABLE_NAME, PRIVILEGE, GRANTABLE FROM DBA_TAB_PRIVS WHERE GRANTEE =" + "'" + input + "'" + " AND TYPE = 'TABLE' ORDER BY TABLE_NAME";
            oc.CommandType = CommandType.Text;

            OracleDataReader odr = oc.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(odr);

            for (int i = 0; i < allTables.Rows.Count; i++)
            {
                bool select = false, sGrantable = false, insert = false, iGrantable = false,
                     update = false, uGrantable = false, delete = false, dGrantable = false;

                string currentTable = allTables.Rows[i].Field<string>(0);

                foreach (DataRow row in dt.Rows)
                {
                    String tableName = row["TABLE_NAME"].ToString();
                    String privilege = row["PRIVILEGE"].ToString();
                    String grantable = row["GRANTABLE"].ToString();

                    if (tableName == currentTable)
                    {
                        if (privilege == "SELECT")
                        {
                            select = true;
                            if (grantable == "YES")
                                sGrantable = true;
                        }
                        if (privilege == "INSERT")
                        {
                            insert = true;
                            if (grantable == "YES")
                                iGrantable = true;
                        }
                        if (privilege == "UPDATE")
                        {
                            update = true;
                            if (grantable == "YES")
                                uGrantable = true;
                        }
                        if (privilege == "DELETE")
                        {
                            delete = true;
                            if (grantable == "YES")
                                dGrantable = true;
                        }
                    }
                }

                dataGridView_ListGrant.Rows.Add(currentTable, select, sGrantable,
                    insert, iGrantable, update, uGrantable, delete, dGrantable);
            }
            con.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            if (txtInput.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhap ten nguoi dung/vai tro", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //con.Close();
                return;
            }

            int rowCount = dataGridView_ListGrant.Rows.Count;
            string[] priv_types = new string[] {"","SELECT", "INSERT","UPDATE" ,"DELETE"};

            for (int i = 0; i < rowCount - 1; i++)
            {
                DataGridViewRow row = dataGridView_ListGrant.Rows[i];

                //int cnt = row.Cells.Count;
                //Console.WriteLine("CNT: " + cnt.ToString());

                for (int j = 1; j < row.Cells.Count - 1 ; j++)
                {
                    string currentTable = row.Cells[0].Value.ToString().ToUpper(); ;

                    bool isChecked = (bool) row.Cells[j].Value;
    
                    string priv_type = priv_types[(j + 1) / 2];

                    string grantable = "NO";
                    if (j % 2 == 0)
                    {
                        grantable = "YES";
                    }


                    bool granted = checkPrivileges(txtInput.Text.Trim().ToUpper(), priv_type, currentTable, grantable, inputType);

                    if (isChecked && !granted)
                    {
                        OracleCommand oc = con.CreateCommand();

                        oc.CommandText = "GRANT " + priv_type + " ON " + currentTable + " TO " + txtInput.Text.Trim().ToUpper();

                        Console.WriteLine(inputType);

                        if (grantable == "YES" && inputType == "User")
                        {
                            oc.CommandText += " WITH GRANT OPTION";
                        }

                        Console.WriteLine(oc.CommandText);

                        oc.ExecuteNonQuery();
                    }
                    if (!isChecked && granted)
                    {

                        OracleCommand oc = con.CreateCommand();

                        oc.CommandText = "REVOKE  " + priv_type + " ON " + currentTable + " FROM " + txtInput.Text.Trim().ToUpper();

                        Console.WriteLine(oc.CommandText);

                        oc.ExecuteNonQuery();
                    }
                }
            }
            
            MessageBox.Show("Cap nhat quyen thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

       
        private void fGrantPrivileges_Load(object sender, EventArgs e)
        {
            string[] cols = new string[] { "Table Name", "Select", "Select (Grantable)",
                "Insert", "Insert (Grantable)","Update", "Update (Grantable)" ,"Delete", "Delete (Grantable)" , ""};

            for (int i = 0; i < cols.Length - 1; i++)
            {
                if (i == 0)
                {
                    DataGridViewTextBoxColumn dataGridView_TableNameCol = new DataGridViewTextBoxColumn();
                    dataGridView_TableNameCol.HeaderText = cols[i];
                    dataGridView_ListGrant.Columns.Add(dataGridView_TableNameCol);
                }
                else
                {
                    DataGridViewCheckBoxColumn dataGridView_Col = new DataGridViewCheckBoxColumn();
                    dataGridView_Col.HeaderText = cols[i];
                    dataGridView_ListGrant.Columns.Add(dataGridView_Col);
                }
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                OracleCommand oc = con.CreateCommand();
                oc.CommandText = "SELECT table_name FROM DBA_TABLES WHERE OWNER = 'U_ADMIN'";
                oc.CommandType = CommandType.Text;

                OracleDataReader dr = oc.ExecuteReader();

                allTables.Load(dr);
                
                for (int i = 0; i < allTables.Rows.Count; i++)
                {
                    dataGridView_ListGrant.Rows.Add(allTables.Rows[i].Field<string>(0), false, false,
                    false, false,
                    false, false,
                    false, false);
                }
                con.Close();
                //dataGridView_ListGrant.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi ket noi: " + ex.Message);
            }
        }

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
            fUsers _fUser = new fUsers();
            _fUser.Show();
            this.Hide();
        }

        private void roleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fAddRole _fAddRoles = new fAddRole();
            _fAddRoles.Show();
            this.Hide();
        }

        private void checkPrivilegesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fCheckPrivileges _fCheckPrivileges = new fCheckPrivileges();
            _fCheckPrivileges.Show();
            this.Hide();
        }

        private void grantRolesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fGrantRoles _fGrantRoles = new fGrantRoles();
            _fGrantRoles.Show();
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
