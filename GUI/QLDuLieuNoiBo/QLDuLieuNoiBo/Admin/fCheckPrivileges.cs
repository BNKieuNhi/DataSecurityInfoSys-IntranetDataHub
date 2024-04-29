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

namespace QLDuLieuNoiBo
{
    public partial class fCheckPrivileges : Form
    {
        OracleConnection con;
        string strCon = @"DATA SOURCE=localhost:1521/PDBQLDLNB; USER ID=U_ADMIN;PASSWORD=123;";
        string dbUser = "SYS";
        string dbUser_password = "21127495";
        bool sys = true;

        public fCheckPrivileges()
        {
            InitializeComponent();
        }

        private void fCheckPrivileges_Load(object sender, EventArgs e)
        {

        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            con = new OracleConnection(strCon);
            try
            {
                con.Open();
                if (txtInput.Text.Trim().Length == 0 )
                {
                    MessageBox.Show("Vui lòng nhap ten user/roles", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string input = txtInput.Text.Trim().ToUpper();
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
                oc.CommandText = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE =" + "'" + input + "'" + " AND TYPE = 'TABLE' ORDER BY TABLE_NAME";
                oc.CommandType = CommandType.Text;

                OracleDataReader dr = oc.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                dataGridView_ListPrivileges.DataSource = dt;

                dataGridView_ListPrivileges.ReadOnly = true;

            }
            catch (Exception ex)
            {
                // X? lý các ngo?i l? n?u có
                Console.WriteLine("Loi ket noi: " + ex.Message);
            }
        }

        private void btnCot_Click(object sender, EventArgs e)
        {
            con = new OracleConnection(strCon);
            try
            {
                con.Open();
                if (txtInput.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhap ten user/roles", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string input = txtInput.Text.Trim().ToUpper();
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
                oc.CommandText = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE =" + "'" + input + "'" + " AND TYPE = 'VIEW' ORDER BY TABLE_NAME";
                oc.CommandType = CommandType.Text;

                OracleDataReader dr = oc.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                dataGridView_ListPrivileges.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi ket noi: " + ex.Message);
            }
        }

        private void grantToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fGrantPrivileges _fGrantPrivileges = new fGrantPrivileges();
            _fGrantPrivileges.Show();
            this.Hide();
        }

        private void usersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fUsers _fUser = new fUsers();
            _fUser.Show();
            this.Hide();
        }

        private void revokePrivilegesRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fRevokeRoles _fRevokeRoles = new fRevokeRoles();
            _fRevokeRoles.Show();
            this.Hide();
        }

        private void roleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fAddRole _fAddRoles = new fAddRole();
            _fAddRoles.Show();
            this.Hide();
        }

        private void grantRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGrantRoles _fGrantRoles = new fGrantRoles();
            _fGrantRoles.Show();
            this.Hide();
        }

        private void colPrivilegesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fRevokeRoles _fRevokeRoles = new fRevokeRoles();
            _fRevokeRoles.Show();
            this.Hide();
        }
    }
}
