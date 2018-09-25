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
            Console.ReadKey();
        }

        private static void opretKunde()
        {
            string statement = "insert into kunder values ('" + "Jesper" + "','" + "Fårekylling" + "'," + "2800" + ")";

            SqlTest.insert(statement);
        }
    }
}
