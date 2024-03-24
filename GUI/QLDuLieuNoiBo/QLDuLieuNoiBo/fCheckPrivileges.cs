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

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkPrivilegesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnBang_Click(object sender, EventArgs e)
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
    }
}
