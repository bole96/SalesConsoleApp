using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    internal abstract class Operator
    {
        protected Korisnik[] korisnik;
        private string paket;
        private double cena;
        private int brojKorisnika;
        private int maksKorisnika;

        public Operator(string paket, double cena)
        {
            this.Paket = paket;
            this.Cena = cena;
            BrojKorisnika = 0;
            MaksKorisnika = 3;
            korisnik = new Korisnik[MaksKorisnika];
        }

        public string Paket { get => paket; set => paket = value; }
        public double Cena { get => cena; set => cena = value; }
        public int BrojKorisnika { get => brojKorisnika; set => brojKorisnika = value; }
        public int MaksKorisnika { get => maksKorisnika; set => maksKorisnika = value; }

        public void DodajKorisnika(Korisnik k)
        {
            if(brojKorisnika < maksKorisnika)
            {
                korisnik[brojKorisnika++] = k;
            }
            else
            {
                Console.WriteLine("Dostigli ste maksimum korisnika!");
            }
        }

        public void SpisakKorisnika()
        {
            foreach(Korisnik k in korisnik)
            {
                if(k != null)
                {
                    Console.WriteLine(k);
                }
            }
        }

        public abstract double CenaPaketa();

        public virtual string Ugovor()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Korisnik k in korisnik)
            {
                if(k != null)
                {
                    if(k.Godine >= 18)
                    {
                        sb.AppendLine($"{k} i moze da potpise ugovor.");
                    }
                    else
                    {
                        sb.AppendLine($"{k} maloletan i ne moze da potpise ugovor.");
                    }
                }
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return Ugovor();
        }

    }
}
