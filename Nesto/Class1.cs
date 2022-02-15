using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesto
{
    public class MojeKlase
    {
        public string _ime = string.Empty;
        public string _prezime = string.Empty;
    }

    public class Predavac : MojeKlase
    {
        public string _kurs = string.Empty;

        public static void Unos()
        {
            Predavac p = new();

            Console.Write("Unesi ime: ");
            p._ime = Console.ReadLine();
            Console.Write("Unesi prezime: ");
            p._prezime = Console.ReadLine();
            Console.Write("Unesi Kurs: ");
            p._kurs = Console.ReadLine();
        }
    }

    public class Polaznik : MojeKlase
    {
        public List<Polaznik> _kursevi = new();
    }
}
