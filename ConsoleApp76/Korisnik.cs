using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    internal class Korisnik
    {
        private string ime;
        private string prezime;
        private bool rezident;
        private int godine;

        public Korisnik(string ime, string prezime, bool rezident,int godine)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Rezident = rezident;
            this.Godine = godine;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public bool Rezident { get => rezident; set => rezident = value; }
        public int Godine { get => godine; set => godine = value; }

        public override string ToString()
        {
            return $"Korisnik: {ime} {prezime} je rezident {rezident} godina: {godine}";
        }


    }
}
