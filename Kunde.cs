using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQL_C_Værksted_Superclass_Test
{
    class Kunde : Superclass
    {
        public static void Select(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(table);
                Console.WriteLine("ID | Fornavn | Efternavn | Postnummer");
                foreach (DataRow kunde in table.Rows)
                {
                    Console.Write(kunde["id"].ToString());
                    Console.Write(" ");
                    Console.Write(kunde["fornavn"].ToString());
                    Console.Write(" ");
                    Console.Write(kunde["efternavn"].ToString());
                    Console.Write(" ");
                    Console.Write(kunde["postnr"].ToString());

                }

                // denførsterække = table.Rows[0] ["navn"].ToString();            
            }
        }
    }
}
