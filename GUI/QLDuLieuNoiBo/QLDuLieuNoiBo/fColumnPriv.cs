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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLDuLieuNoiBo
{
    public partial class fColumnPriv : Form
    {
        #region Variable
        OracleConnection _con;
        public static string State = "-1";
        string inputType = "";


        string dbUser = "SYS";
        string dbUser_password = "21127495";
        bool sys = true;
        #endregion

        public fColumnPriv()
        {
            InitializeComponent();

            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
        }

        #region Public Function
        private void btnSearch_Click(object sender, EventArgs e)
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
            try
            {
                // Mở kết nối
                _con.Open();
                if (txtInput.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui long nhap ten user/roles", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string input = txtInput.Text.Trim().ToUpper();
                string sqlCheck = "SELECT COUNT(*) FROM DBA_USERS WHERE USERNAME = '" + input + "'";
                Console.WriteLine(sqlCheck);
                OracleCommand cmdCheck = new OracleCommand(sqlCheck, _con);

                int count = 0;
                count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                if (count > 0)
                {
                    inputType = "User";
                }

                sqlCheck = "SELECT COUNT(*) FROM DBA_ROLES WHERE ROLE = '" + input + "'";
                Console.WriteLine(sqlCheck);
                cmdCheck = new OracleCommand(sqlCheck, _con);

                count += Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (count <= 0)
                {
                    MessageBox.Show("Khong tim thay nguoi dung/vai tro", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (inputType == "")
                {
                    inputType = "Role";
                    MessageBox.Show("Thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                OracleCommand oc = _con.CreateCommand();
                oc.CommandText = "SELECT table_name FROM DBA_TABLES WHERE OWNER ='" + dbUser + "'";
                oc.CommandType = CommandType.Text;

                OracleDataReader dr = oc.ExecuteReader();

                DataTable all_tables = new DataTable();
                all_tables.Load(dr);
                foreach (DataRow row in all_tables.Rows)
                {
                    TenBang.Items.Add(row["TABLE_NAME"].ToString());
                }

                _con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _con.Close();
                throw;
            }
        }
        #endregion

        private void TenBang_SelectedIndexChanged(object sender, EventArgs e)
        {
            _con.Open();

            if (TenBang.SelectedIndex != -1)
            {
                OracleCommand oc1 = _con.CreateCommand();
                oc1.CommandText = "SELECT DISTINCT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE TABLE_NAME = '" + TenBang.SelectedItem.ToString().ToUpper() + "'";
                Console.WriteLine(oc1.CommandText);
                oc1.CommandType = CommandType.Text;

                OracleDataReader dr1 = oc1.ExecuteReader();

                DataTable all_columns = new DataTable();
                all_columns.Load(dr1);
                TenCot.Items.Clear();
                radioButton1.Checked = false;

                foreach (DataRow row in all_columns.Rows)
                {
                    TenCot.Items.Add(row["COLUMN_NAME"].ToString());
                }
            }

            _con.Close();
        }

        private void TenCot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TenCot.SelectedIndex != -1)
            {
                MessageBox.Show("Hop le!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton radioButton1 = sender as System.Windows.Forms.RadioButton;

            if (radioButton1.Checked)
            {
                // RadioButton is checked
                State = "1";
            }
            else
            {
                // RadioButton is unchecked
                State = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _con.Open();
            //string viewSql = "CREATE OR REPLACE VIEW V_XEM" + TenBang.SelectedItem.ToString() + " AS SELECT " + TenCot + " FROM " + TenBang;
            OracleCommand cmd = _con.CreateCommand();

            cmd.CommandText = "CREATE OR REPLACE VIEW V_XEM" + TenCot.SelectedItem.ToString().ToUpper() +
             " AS SELECT " + TenCot.SelectedItem.ToString().ToUpper() +
             " FROM " + TenBang.SelectedItem.ToString().ToUpper();

            Console.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "GRANT SELECT ON V_XEM" + TenCot.SelectedItem.ToString().ToUpper() +
                " TO " + txtInput.Text.Trim().ToUpper();
            if (State == "1" && inputType == "User")
            {
                cmd.CommandText += " WITH GRANT OPTION";
            }

            Console.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT DISTINCT dp.table_name AS view_name, dp.privilege AS PRIVILEGE, dp.grantable AS GRANTABLE " +
                "FROM dba_tab_privs dp " +
                "WHERE dp.grantee = '" + txtInput.Text.Trim().ToUpper() + "' " +
                "AND dp.privilege = 'SELECT'";

            Console.WriteLine(cmd.CommandText);
            cmd.CommandType = CommandType.Text;

            OracleDataReader odr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(odr);

            dataGridView1.DataSource = dt.DefaultView;

            radioButton1.Checked = false;
            _con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _con.Open();

            //string grantSql = "GRANT UPDATE ON V_XEM" + TenBang.SelectedItem.ToString() + " TO " + txtInput;
            OracleCommand cmd = _con.CreateCommand();

            cmd.CommandText = "GRANT UPDATE(" + TenCot.SelectedItem.ToString().ToUpper() + ") ON " + TenBang.SelectedItem.ToString().ToUpper() + " TO " + txtInput.Text.Trim();

            if (State == "1" && inputType == "User")
            {
                cmd.CommandText += " WITH GRANT OPTION";
            }

            Console.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT GRANTEE, TABLE_NAME, COLUMN_NAME, PRIVILEGE, GRANTABLE " +
                "FROM all_col_privs dp " +
                "WHERE dp.grantee = '" + txtInput.Text.Trim().ToUpper() + "' ";

            Console.WriteLine(cmd.CommandText);
            cmd.CommandType = CommandType.Text;

            OracleDataReader odr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(odr);

            dataGridView1.DataSource = dt.DefaultView;
            radioButton1.Checked = false;

            _con.Close();
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
    }
}
