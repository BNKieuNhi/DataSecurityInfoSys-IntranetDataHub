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
    public partial class fGrantPrivileges : Form
    {
        OracleConnection con;

        string dbUser = "SYS";
        string dbUser_password = "21127495";
        bool sys = true;

        DataTable pri_tables = new DataTable();
        DataTable allTables = new DataTable();


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

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txtInput.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhap ten user/roles", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridView_ListGrant.Rows.Clear();
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

                pri_tables.Rows.Add(currentTable, select, sGrantable,
                    insert, iGrantable, update, uGrantable, delete, dGrantable);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void fGrantPrivileges_Load(object sender, EventArgs e)
        {
            string[] cols = new string[] { "Table Name", "Select", "Select (Grantable)",
                "Insert", "Insert (Grantable)"
            ,"Update", "Update (Grantable)"
            ,"Delete", "Delete (Grantable)" , ""};

            for (int i = 0; i < cols.Length; i++)
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
                con.Open();

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
        
       
    }
}
