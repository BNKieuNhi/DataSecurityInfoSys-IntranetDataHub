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
                comboBox1.Items.Add(col);
            }

            
            con.Close();
        }

        private void revokePrivilegesRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fGrantRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim().Length == 0 || txtInput.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui long nhap day du du lieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            con.Open();

            String role = comboBox1.Text.Trim().ToUpper();
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
            }
        }
    }
}
