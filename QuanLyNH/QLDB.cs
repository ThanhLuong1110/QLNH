using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNH
{
    internal class QLDB
    {
        public static class DatabaseHelper
        {
            private static string ChuoiKN = "Data Source=localhost;Initial Catalog=QLNH;Integrated Security=True;Encrypt=False";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(ChuoiKN);
            }

            public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }

            public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
