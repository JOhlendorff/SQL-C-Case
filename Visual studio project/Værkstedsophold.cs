using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQL_C_Værksted_Superclass_Test
{
    class Værkstedsophold : Superclass
    {
        public static void Select(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(table);
                foreach (DataRow værkstedsophold in table.Rows)
                {
                    Console.WriteLine(værkstedsophold["regnr"].ToString());
                    Console.WriteLine(værkstedsophold["id"].ToString());
                    Console.WriteLine(værkstedsophold["DatoforCheckIn"].ToString());
                    Console.WriteLine(værkstedsophold["DatoforCheckUd"].ToString());

                }

                // denførsterække = table.Rows[0] ["navn"].ToString();            
            }
        }
    }
}
