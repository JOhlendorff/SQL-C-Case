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
    }
}
