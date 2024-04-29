using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDuLieuNoiBo
{
    public class Database
    {
        /*        private string strCon = @"DATA SOURCE=localhost:1521/PDBQLDLNB; USER ID=U_ADMIN;PASSWORD=123;";
        */
        public static string host_name = "localhost:1521/PDBQLDLNB";
        public static OracleConnection conn;
        public static DataTable dtable;
        public static OracleCommand cmd;
/*        public Database()
        {
            try
            {
                conn = new OracleConnection(strCon);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connected failed: " + ex.Message);
            }
        }*/
        public static void InitConnection(String username, String password)
        {
            String strCon = @"Data Source=" + host_name + ";User ID=" + username + ";Password=" + password + "";

            conn = new OracleConnection();
            conn.ConnectionString = strCon;

            try
            {
                //Mở kết nối
                conn.Open();

                ////Kiểm tra kết nối
                //if (Con.State == ConnectionState.Open)
                //{
                //    MessageBox.Show("Kết nối DB thành công");
                //}

            }
            catch (OracleException ex)
            {
                conn = null;
                MessageBox.Show("Không thể kết nối với DB");
                throw new Exception(ex.Message);
            }
        }
        public DataTable SelectData(string sql)
        {
            try
            {
                using (cmd = new OracleCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;

                    using (var adapter = new OracleDataAdapter(cmd))
                    {
                        var dtable = new DataTable();
                        adapter.Fill(dtable);
                        return dtable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
                return null;
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                using (cmd = new OracleCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dtable = new DataTable();
                            dtable.Load(reader);
                            return dtable.Rows[0];
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                return null;
            }
        }

        public int Execute(string sql)
        {
            try
            {
                using (cmd = new OracleCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    
                    Console.WriteLine(sql);
                    var res = cmd.ExecuteNonQuery();
                    return res;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
                return -100;
            }
        }
        public static int isUserValid(string username) // Hàm kiểm tra User có tồn tại hay không
        {
            OracleCommand cmd = new OracleCommand();

            //Gán kết nối
            cmd.Connection = conn;

            //Gán lệnh SQL
            string sql = "SELECT * FROM all_users WHERE USERNAME = " + "'" + username + "'";
            cmd.CommandText = sql;
            Console.WriteLine(sql);
            //Kiểm tra
            OracleDataReader reader = cmd.ExecuteReader();
            Console.WriteLine(reader);
            //bool exists = Convert.ToBoolean(cmd.ExecuteScalar());

            if (reader.Read())
            {
                //Giải phóng bộ nhớ
                cmd.Dispose();
                cmd = null;
                return 1;
            }
            else
            {
                //Giải phóng bộ nhớ
                cmd.Dispose();
                cmd = null;
                return 0;
            }
        }
    }
}
