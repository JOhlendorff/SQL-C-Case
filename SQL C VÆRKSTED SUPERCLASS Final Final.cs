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
            string færdig;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu, vælg aktion");
                Console.WriteLine("1. Liste");
                Console.WriteLine("2. Opret");
                Console.WriteLine("3. Opdater");
                Console.WriteLine("4. Slet");
                //Console.WriteLine("5. Sorter");
                string brugerValg = Console.ReadLine();
                string brugerValg2;
                Console.Clear();
                string data;
                string[] separators = { ",", " " };
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
                        Console.Clear();
                        switch (brugerValg2)
                        {
                            case "1":
                                Console.WriteLine("Hvad vil du sortere kunder efter?");
                                Console.WriteLine("1. Id");
                                Console.WriteLine("2. Fornavn");
                                Console.WriteLine("3. Efternavn");
                                Console.WriteLine("4. Postnr");
                                brugerValg = Console.ReadLine();
                                Console.Clear();
                                switch(brugerValg)
                                {
                                    case "1":
                                        Kunde.Select("select * from kunder");
                                        break;
                                    case "2":
                                        Kunde.Select("select * from kunder order by fornavn");
                                        break;
                                    case "3":
                                        Kunde.Select("select * from kunder order by efternavn");
                                        break;
                                    case "4":
                                        Kunde.Select("select * from kunder order by postnr");
                                        break;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Hvad vil du sortere biler efter?");
                                Console.WriteLine("1. Regnr");
                                Console.WriteLine("2. Mærke");
                                Console.WriteLine("3. Model");
                                Console.WriteLine("4. Årgang");
                                Console.WriteLine("5. Km");
                                Console.WriteLine("6. Brændstoftype");
                                Console.WriteLine("7. Vægt");
                                brugerValg = Console.ReadLine();
                                Console.Clear();
                                switch (brugerValg)
                                {
                                    case "1":
                                        BilDotCs.Select("select * from bil");
                                        break;
                                    case "2":
                                        BilDotCs.Select("select * from bil order by id");
                                        break;
                                    case "3":
                                        BilDotCs.Select("select * from bil order by mærke");
                                        break;
                                    case "4":
                                        BilDotCs.Select("select * from bil order by model");
                                        break;
                                    case "5":
                                        BilDotCs.Select("select * from bil order by årgang");
                                        break;
                                    case "6":
                                        BilDotCs.Select("select * from bil order by km");
                                        break;
                                    case "7":
                                        BilDotCs.Select("select * from bil order by brændstoftype");
                                        break;
                                    case "8":
                                        BilDotCs.Select("select * from bil order by vægt");
                                        break;

                                }
                                break;
                            case "3":
                                Console.WriteLine("Hvad vil du sortere værkstedsophold efter?");
                                Console.WriteLine("1. Registreringsnr");
                                Console.WriteLine("2. Id");
                                Console.WriteLine("3. Check-ind dato");
                                Console.WriteLine("4. Check-ud dato");
                                brugerValg = Console.ReadLine();
                                Console.Clear();
                                switch (brugerValg)
                                {
                                    case "1":
                                        Værkstedsophold.Select("select * from værkstedsophold order by regnr");
                                        break;
                                    case "2":
                                        Værkstedsophold.Select("select * from værkstedsophold");
                                        break;
                                    case "3":
                                        Værkstedsophold.Select("select * from værkstedsophold order by DatoforCheckIn");
                                        break;
                                    case "4":
                                        Værkstedsophold.Select("select * from værkstedsophold order by DatoforCheckUd");
                                        break;
                                }
                                break;
                            case "4":
                                Console.WriteLine("Hvad vil du sortere efter?");
                                Console.WriteLine("1. Registreringsnr");
                                Console.WriteLine("2. Id");
                                Console.WriteLine("3. Oprettelsesdato");
                                brugerValg = Console.ReadLine();
                                Console.Clear();
                                switch (brugerValg)
                                {
                                    case "1":
                                        Værkstedbesøg.Select("select * from værkstedsbesøg order by regnr");
                                        break;
                                    case "2":
                                        Værkstedbesøg.Select("select * from værkstedsbesøg");
                                        break;
                                    case "3":
                                        Værkstedbesøg.Select("select * from værkstedsbesøg order by registreringsDato");
                                        break;
                                }
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
                        Console.Clear();
                        switch (brugerValg2)
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
                                    Værkstedbesøg.Command("insert into værkstedsbesøg values (" + dataSeparate[0] + ",'" + dataSeparate[1] + "')");
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
                        Console.Clear();
                        switch (brugerValg2)
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
                                    Console.WriteLine("Det du har skrevet passer ikke i tabellens format");
                                }
                                break;

                            case "2":
                                Console.WriteLine("Indtast registreringsnummer, nyt kunde id, nyt mærke, ny model, ny årgang, ny km distance kørt, ny brændstoftype og ny vægt. Adskil med \",\"");
                                data = Console.ReadLine();
                                data.Trim();
                                dataSeparate = data.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                                try
                                {
                                    BilDotCs.Command("update bil set id = '" + dataSeparate[1] + "', mærke ='" + dataSeparate[2] + "', model = '" + dataSeparate[3] + "', årgang =" + dataSeparate[4] + ", km = " + dataSeparate[5] + ", brændstoftype = '" + dataSeparate[6] + "', vægt = " + dataSeparate[7] + " where regnr = " + dataSeparate[0]);
                                }
                                catch
                                {
                                    Console.WriteLine("Du har skrevet noget der ikke passer i tabellens format");
                                }
                                break;
                            case "3":
                                Console.WriteLine("Indtast ID, ny checkindato, ny checkuddato og ny regnr. Adskil med \",\"");
                                data = Console.ReadLine();
                                data.Trim();
                                dataSeparate = data.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                                try
                                {
                                    Værkstedsophold.Command("update værkstedsophold set DatoforCheckIn = '" + dataSeparate[1] + "', DatoforCheckUd = '" + dataSeparate[2] + "', regnr = " + dataSeparate[3] + " where id = " + dataSeparate[0]);
                                }
                                catch
                                {
                                    Console.WriteLine("Du har skrevet noget forkert din dumme jøde");
                                }
                                break;
                            case "4":
                                Console.WriteLine("Indtast ID, ny registreringsdato og nyt regnr. Adskil med \",\"");
                                data = Console.ReadLine();
                                data.Trim();
                                dataSeparate = data.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                                try
                                {
                                    Værkstedbesøg.Command("update værkstedsbesøg set registreringsDato = " +
                                        "'" + dataSeparate[1] + "', regnr = " + dataSeparate[2] + " where id = " + dataSeparate[0]);
                                }
                                catch
                                {
                                    Console.WriteLine("Din indtastning passer ikke i tabellens format");
                                }
                                break;
                        }

                        break;
                    case "4":
                        Console.WriteLine("1. Slet kunde");
                        Console.WriteLine("2. Slet bil");
                        Console.WriteLine("3. Slet værkstedsophold");
                        Console.WriteLine("4. Slet værkstedsbesøg");
                        brugerValg2 = Console.ReadLine();
                        Console.Clear();
                        switch (brugerValg2)
                        {
                            case "1":
                                Console.WriteLine("Indtast ID for kunden der slettes");
                                data = Console.ReadLine();
                                try
                                {
                                    Kunde.Command("delete from kunder where id = " + data);
                                }
                                catch
                                {
                                    Console.WriteLine("ID er forkert");
                                }
                                break;
                            case "2":
                                Console.WriteLine("Indtast registreringsnummer for bilen der slettes");
                                data = Console.ReadLine();
                                try
                                {
                                    BilDotCs.Command("delete from bil where regnr = " + data);
                                }
                                catch
                                {
                                    Console.WriteLine("ID er forkert");
                                }
                                break;
                            case "3":
                                Console.WriteLine("Indtast ID for værkstedsopholdet der slettes");
                                data = Console.ReadLine();
                                try
                                {
                                    Værkstedsophold.Command("delete from værkstedsophold where id = " + data);
                                }
                                catch
                                {
                                    Console.WriteLine("ID er forkert");
                                }
                                break;
                            case "4":
                                Console.WriteLine("Indtast ID for værkstedsbesøget der slettes");
                                data = Console.ReadLine();
                                try
                                {
                                    Værkstedbesøg.Command("delete from værkstedsbesøg where id = " + data);
                                }
                                catch
                                {
                                    Console.WriteLine("ID er forkert");
                                }
                                break;
                            default:
                                Console.WriteLine("Du valgt et ugyldigt ID");
                                break;

                        }
                        break;
                    //case "5":
                    //    Console.WriteLine("Hvad vil du sortere?");
                    //    Console.WriteLine("1. Kunde");
                    //    Console.WriteLine("2. Bil");
                    //    Console.WriteLine("3. Ophold");
                    //    Console.WriteLine("4. Besøg");
                    //    brugerValg2 = Console.ReadLine();
                    //    Console.Clear();
                    //    switch (brugerValg2)
                    //    {
                    //        case "1":
                    //            Console.WriteLine("Hvad vil du sortere kunde efter?");
                    //            Console.WriteLine("1. Id");
                    //            Console.WriteLine("2. Fornavn");
                    //            Console.WriteLine("3. Efternavn");
                    //            Console.WriteLine("4. Adresse");
                    //            brugerValg = Console.ReadLine();
                    //            switch(brugerValg)
                    //            {
                    //                case "1":
                    //                    Kunde.Command()
                    //                    break;
                    //            }
                    //            break;
                    //        case "2":
                    //            Console.WriteLine("Hvad vil du sortere bil efter?");
                    //            Console.WriteLine("1. Registreringsnr");
                    //            Console.WriteLine("2. Mærker");
                    //            Console.WriteLine("3. Model");
                    //            Console.WriteLine("4. Årgang");
                    //            Console.WriteLine("5. Km");
                    //            Console.WriteLine("6. Brændstoftype");
                    //            Console.WriteLine("7. Vægt");
                    //            brugerValg = Console.ReadLine();
                    //            break;
                    //        case "3":
                    //            Console.WriteLine("Hvad vil du sortere ophold efter?");
                    //            Console.WriteLine("1. Registreringsnr");
                    //            Console.WriteLine("2. Id");
                    //            Console.WriteLine("3. Check-in dato");
                    //            Console.WriteLine("4. Check-ud dato");
                    //            brugerValg = Console.ReadLine();
                    //            break;
                    //        case "4":
                    //            Console.WriteLine("Hvad vil du sortere besøg efter?");
                    //            Console.WriteLine("1. Registreringsnr");
                    //            Console.WriteLine("2. Id");
                    //            Console.WriteLine("3. Registreringsdato");
                    //            brugerValg = Console.ReadLine();
                    //            break;
                    //    }
                        //break;
                    default:
                        Console.WriteLine("Du har ikke valgt en gyldig mulighed");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Exit? Ja/Nej");
                færdig = Console.ReadLine();
                //if (færdig != "Ja" || færdig != "ja")
                //    færdig = "Nej";
                Console.ReadKey();

            }
            while (færdig == "Nej" || færdig == "nej" && færdig != "Ja" && færdig != "ja");

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