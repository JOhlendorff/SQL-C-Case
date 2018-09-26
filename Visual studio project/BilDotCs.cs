using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Connection
{
    class BilDotCs
    {
        private static string ConnectionString = "Data Source = SKAB2-PC-03;Initial Catalog=Autoværksted; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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

                foreach (DataRow bil in table.Rows)
                {
                    Console.WriteLine(bil["id"].ToString());
                    Console.WriteLine(bil["mærke"].ToString());
                    Console.WriteLine(bil["model"].ToString());
                    Console.WriteLine(bil["årgang"].ToString());
                    Console.WriteLine(bil["km"].ToString());
                    Console.WriteLine(bil["brændstoftype"].ToString());
                    Console.WriteLine(bil["vægt"].ToString());
                }

                // denførsterække = table.Rows[0] ["navn"].ToString();            
            }
        }
        public static void update(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
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

