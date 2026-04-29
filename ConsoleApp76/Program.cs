using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Korisnik k1 = new Korisnik("Pera","Peric", true, 18);
            Korisnik k2 = new Korisnik("Luka", "Lukic", true, 15);
            Korisnik k3 = new Korisnik("Mika", "Mikic", false, 20);

            Operator o1 = new Prodaja("starter", 1000, "online");
            Operator o2 = new Prodaja("starter", 1000, "salter");
            Operator o3 = new Prodaja("premium", 3000, "online");
            Operator o4 = new Prodaja("premium", 3000, "salter");

            o1.DodajKorisnika(k1);
            o1.DodajKorisnika(k2);
            o1.DodajKorisnika(k3);
            o1.SpisakKorisnika();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine(o1);
            Console.WriteLine("*********************************************************************");
            o2.DodajKorisnika(k1);
            o2.DodajKorisnika(k2);
            o2.DodajKorisnika(k3);
            o2.SpisakKorisnika();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine(o2);
            Console.WriteLine("*********************************************************************");
            o3.DodajKorisnika(k1);
            o3.DodajKorisnika(k2);
            o3.DodajKorisnika(k3);
            o3.SpisakKorisnika();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine(o3);
            Console.WriteLine("*********************************************************************");
            o4.DodajKorisnika(k1);
            o4.DodajKorisnika(k2);
            o4.DodajKorisnika(k3);
            o4.SpisakKorisnika();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine(o4);
            Console.WriteLine("*********************************************************************");

        }
    }
}
