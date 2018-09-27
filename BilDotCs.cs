using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQL_C_Værksted_Superclass_Test
{
    public class BilDotCs : Superclass
    {
        public static void Select(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(table);
                Console.WriteLine("ID | Mærke | Model | Årgang | Km | Brændstoftype | Vægt");
                foreach (DataRow bil in table.Rows)
                {
                    Console.Write(bil["id"].ToString());
                    Console.Write(" ");
                    Console.Write(bil["mærke"].ToString());
                    Console.Write(" ");
                    Console.Write(bil["model"].ToString());
                    Console.Write(" ");
                    Console.Write(bil["årgang"].ToString());
                    Console.Write(" ");
                    Console.Write(bil["km"].ToString());
                    Console.Write(" ");
                    Console.Write(bil["brændstoftype"].ToString());
                    Console.Write(" ");
                    Console.Write(bil["vægt"].ToString());

                }


                // denførsterække = table.Rows[0] ["navn"].ToString();            
            }
        }
    }
}
