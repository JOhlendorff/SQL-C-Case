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
        }

        private static void opretKunde()
        {
            string statement = "insert into kunder values ('" + "Anders And" + "','" + "Telegrafvej 9" + "'," + 90 + ")";

            SqlTest.insert(statement);
        }
    }
}
