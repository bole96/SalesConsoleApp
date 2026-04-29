using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    internal class Prodaja : Operator
    {
        private string nacinKupovine;

        public Prodaja(string paket, double cena, string nacinKupovine) : base(paket, cena)
        {
            this.nacinKupovine = nacinKupovine;
        }

        public override double CenaPaketa()
        {
            double konacnaCena = 0;

            if(nacinKupovine == "online")
            {
                konacnaCena = Cena * 0.7;
            }
            else
            {
                konacnaCena = Cena;
            }
            return konacnaCena;
        }

        public override string Ugovor()
        {
            StringBuilder sb = new StringBuilder();
            if(Paket == "starter" ||  Paket == "premium")
            {
                sb.Append(base.Ugovor());
            }
            return sb.ToString();

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Korisnik k in korisnik)
            {
                if(k != null)
                {
                    if(k.Godine >= 18 && k.Rezident)
                    {
                        sb.AppendLine($"{k} Cena paketa iznosi: {CenaPaketa()}");
                    }
                    else if(k.Godine >= 18 && !k.Rezident)
                    {
                        sb.AppendLine($"{k.ToString()} - Nije rezident.");
                    }
                    else
                    {
                        sb.AppendLine($"{k.ToString()} - Maloletan.");
                    }
                }
            }
            return Ugovor() + sb.ToString();
        }











    }
}
