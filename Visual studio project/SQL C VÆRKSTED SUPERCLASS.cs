using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SQL_C_Værksted_Superclass_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu, vælg aktion");
            Console.WriteLine("1. Liste");
            Console.WriteLine("2. Opret");
            Console.WriteLine("3. Opdater");
            Console.WriteLine("4. Slet");
            string brugerValg = Console.ReadLine();
            string brugerValg2;
            string data;
            string[] separators = { "," , " "};
            string[] dataSeparate;
            switch (brugerValg)
            
            {
                case "1":
                    Console.WriteLine("Liste, vælg tabel");
                    Console.WriteLine("1. Kunde");
                    Console.WriteLine("2. Bil");
                    Console.WriteLine("3. Værkstedsophold");
                    Console.WriteLine("4. Værkstedsbesøg");
                    brugerValg2 = Console.ReadLine();
                    switch (brugerValg2)
                    {
                        case "1":
                            Kunde.Select("select * from kunder");
                            break;
                        case "2":
                            BilDotCs.Select("select * from bil");
                            break;
                        case "3":
                            Værkstedsophold.Select("select * from værkstedsophold");
                            break;
                        case "4":
                            Værkstedbesøg.Select("select * from værkstedsbesøg");
                            break;
                        default:
                            Console.WriteLine("Du har valgt noget forkert");
                            break;

                    }
                    break;
                case "2":
                    Console.WriteLine("Opret, vælg tabel");
                    Console.WriteLine("1. Kunde");
                    Console.WriteLine("2. Bil");
                    Console.WriteLine("3. Værkstedsophold");
                    Console.WriteLine("4. Værkstedsbesøg");
                    brugerValg2 = Console.ReadLine();
                    switch(brugerValg2)
                    {
                        case "1":
                            Console.WriteLine("Indtast fornavn, efternavn og postnr. Adskil med \",\"");
                            data = Console.ReadLine();
                            data.Trim();
                            dataSeparate = data.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            try
                            {
                                Kunde.Command("insert into kunder values ('" + dataSeparate[0] + "','" + dataSeparate[1] + "'," + dataSeparate[2] + ")");
                            }
                            catch
                            {
                                Console.WriteLine("Du har skrevet noget forkert");
                            }
                            break;
                        case "2":
                            Console.WriteLine("indast kundeid, mærke, model, årgang, km, brændstoftype og vægt. Adskil med \",\"");
                            data = Console.ReadLine();
                            data.Trim();
                            dataSeparate = data.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            try
                            {
                                BilDotCs.Command("insert into bil values ('" + dataSeparate[0] + "','" + dataSeparate[1] + "','" + dataSeparate[2] + "','" + dataSeparate[3] + "','" + dataSeparate[4] + "','" + dataSeparate[5] + "','" + dataSeparate[6] + "')");
                            }
                            catch
                            {
                                Console.WriteLine("Du har skrevet noget forkert");
                            }
                            break;
                        case "3":
                            Console.WriteLine("indast registreringsnummer, checkin dato og checkud dato. Adskil med \",\"");
                            data = Console.ReadLine();
                            data.Trim();
                            dataSeparate = data.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            try
                            {
                                Værkstedsophold.Command("insert into værkstedsophold values (" + dataSeparate[0] + ",'" + dataSeparate[1] + "','" + dataSeparate[2] + "')");
                            }
                            catch
                            {
                                Console.WriteLine("Du har skrevet noget forkert");
                            }
                            break;
                        case "4":
                            Console.WriteLine("indast registreringsnummer og dato for registrering. Adskil med \",\"");
                            data = Console.ReadLine();
                            data.Trim();
                            dataSeparate = data.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            try
                            {
                                Værkstedbesøg.Command("insert into værkstedsbesøg values (" + dataSeparate[0] + "," + dataSeparate[1] + ",'" + dataSeparate[2] + "')");
                            }
                            catch
                            {
                                Console.WriteLine("Du har skrevet noget forkert");
                            }
                            break;
                        default:
                            Console.WriteLine("Du har ikke valgt en gyldig mulighed");
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine("Update, vælg tabel");
                    Console.WriteLine("1. Kunde");
                    Console.WriteLine("2. Bil");
                    Console.WriteLine("3. Værkstedsophold");
                    Console.WriteLine("4. Værkstedsbesøg");
                    brugerValg2 = Console.ReadLine();
                    switch(brugerValg2)
                    {
                        case "1":
                            Console.WriteLine("Indtast kundeID, Nyt Fornavn, Nyt Efternavn og Nyt Postnummer. Adskil med \",\"");
                            data = Console.ReadLine();
                            data.Trim();
                            dataSeparate = data.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            try
                            {
                                Kunde.Command("update kunder set fornavn = '" + dataSeparate[1] + "', efternavn = '" + dataSeparate[2] + "', postnr = " + dataSeparate[3] + " where id = " + dataSeparate[0]);
                            }
                            catch
                            {
                                Console.WriteLine("Du har skrevet noget forkert din dumme jøde");
                            }
                            break;

                        case "2":
                            Console.WriteLine("Indtast ID, Nyt Fornavn, Nyt Efternavn og Nyt Postnummer. Adskil med \",\"");
                            data = Console.ReadLine();
                            data.Trim();
                            dataSeparate = data.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            try
                            {
                                Kunde.Command("update kunder set fornavn = '" + dataSeparate[1] + "', efternavn = '" + dataSeparate[2] + "', postnr = " + dataSeparate[3] + " where id = " + dataSeparate[0]);
                            }
                            catch
                            {
                                Console.WriteLine("Du har skrevet noget forkert din dumme jøde");
                            }
                            break;
                    }

                    break;
                case "4":
                    Console.WriteLine("Slet kunde/bil/værkstedsophold/værkstedsbesøg");
                    brugerValg2 = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Du har ikke valgt en gyldig mulighed");
                    break;
            }





            Console.ReadKey();






        }

        //private static void opretKunde()
        //{
        //    string statement = "insert into kunder values ('" + "Jesper" + "','" + "Fårekylling" + "'," + "2800" + ")";

        //    SqlTest.insert(statement);
        //}


        //private static void opretBil()
        //{
        //    string statement = "insert into bil values (" + "1" + ",'" + "Honda" + "','" + "Civic" + "'," + "2008" + "," + "200000" + ",'" + "Diesel" + "'," + "1050" + ")";

        //    BilDotCs.insert(statement);

        //}
        //private static void updateBil()
        //{
        //    string statement = "update kunder set fornavn = 'Mads' where id = 1";
        //    BilDotCs.update(statement);
        //}
        //private static void deleteKunde()
        //{
        //    string statement = "delete from bil where id = 1";
        //    string statement2 = "delete from kunder where id = 1";

        //    SqlTest.delete(statement);
        //    SqlTest.delete(statement2);
        //}

    }
}