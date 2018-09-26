using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Connection
{
    class SqlTest
    {
        private static string ConnectionString = "Data Source = SKAB2-PC-09;Initial Catalog=Autoværksted; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static void insert(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }
        public static void Select(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(table);

                foreach (DataRow kunde in table.Rows)
                {
                    Console.WriteLine(kunde["id"].ToString());
                    Console.WriteLine(kunde["fornavn"].ToString());
                    Console.WriteLine(kunde["efternavn"].ToString());
                    Console.WriteLine(kunde["postnr"].ToString());

                }

                // denførsterække = table.Rows[0] ["navn"].ToString();            
            }
        }
        public static void delete(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }

        }
    }

}
