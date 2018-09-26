using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            opretKunde();
            SqlTest.Select("select * from kunder");
            opretBil();
            BilDotCs.Select("select * from bil");
            updateBil();
            deleteKunde();
            Console.ReadKey();

        }

        private static void opretKunde()
        {
            string statement = "insert into kunder values ('" + "Jesper" + "','" + "Fårekylling" + "'," + "2800" + ")";

            SqlTest.insert(statement);
        }
        private static void deleteKunde()
        {
            string statement = "delete from kunder where fornavn = 'Mads'";
            SqlTest.delete(statement);
        }


        private static void opretBil()
        {
            string statement = "insert into bil values (" + "1" + ",'" + "Honda" + "','" + "Civic" + "'," + "2008" + "," + "200000" + ",'" + "Diesel" + "'," + "1050" + ")";

            BilDotCs.insert(statement);

        }
        private static void updateBil()
        {
            string statement = "update kunder set fornavn = 'Mads' where id = 1";
            BilDotCs.update(statement);
        }
        
    }
}
