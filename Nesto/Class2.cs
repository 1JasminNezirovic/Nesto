using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesto
{
    public static class Meni
    {
        public static void PrviMeni()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("1. Predavac             !");
            Console.WriteLine("2. Polaznik             !");
            Console.WriteLine("3. Izlaz                !");
            Console.WriteLine("=========================");
            Console.Write("Izbor: ");
        }
        public static void MeniPredavac()
        {
            Console.WriteLine("================================");
            Console.WriteLine("1. Informacije o Predavacu     !");
            Console.WriteLine("2. Prikaz                      !");
            Console.WriteLine("3. Izlaz                       !");
            Console.WriteLine("================================");
            Console.Write("Izbor: ");

            string unos = Console.ReadLine();
            switch (unos)
            {
                case "1":
                    Console.Clear();
                    Predavac.Unos();
                    Console.ReadLine();
                    break;

                case "2":
                    break;

                case "3":
                    break;

                default:
                    Console.WriteLine("Ovo ti nesto ne valja");
                    break;
            }
            Console.Clear();
        }
        public static void MeniPolaznik()
        {
            Console.WriteLine("================================");
            Console.WriteLine("1. Informacije o Polazniku     !");
            Console.WriteLine("2. Unesite Kurseve             !");
            Console.WriteLine("3. Prikaz                      !");
            Console.WriteLine("4. Izlaz                       !");
            Console.WriteLine("================================");
            Console.Write("Izbor: ");

            string unos = Console.ReadLine();
            switch (unos)
            {
                case "1":
                    Console.Clear();
                    Console.ReadLine();
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    break;

                default:
                    Console.WriteLine("Ovo ti nesto ne valja");
                    break;
            }
            Console.Clear();   
            }
        }
    }




