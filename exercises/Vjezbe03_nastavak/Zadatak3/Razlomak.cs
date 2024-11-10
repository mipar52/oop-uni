using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    internal class Razlomak
    {
        public double brojnik { get; private set; }
        private double nazivnik;
        private const char separator = '/';
        public double Nazivnik
        {
            get { return nazivnik; }
            private set
            {
                if (value == 0)
                {
                    throw new Exception("Nazivnik ne moze biti nula!!");
                }
                nazivnik = value;
            }
        }
        public double Rezutat() { return brojnik / nazivnik; }

        public Razlomak(double brojnik, double nazivnik)
        {
            this.brojnik = brojnik;
            this.Nazivnik = nazivnik;
        }

        public double NajveciZajednickiDjeljitelj()
        {
            for (double i = Math.Min(Nazivnik, brojnik); i >= 2; i--)
            {
                if (brojnik % i == 0 && nazivnik % i == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public static Razlomak Parse(string input)
        {
            string[] detalji = input.Split(separator);
            if (detalji.Length != 2) { return null; }

            if (!int.TryParse(detalji[0], out int brojnik) || !int.TryParse(detalji[1], out int nazivnik)) { return null; }
            return new Razlomak(brojnik, nazivnik);
        }

        public override string ToString()
        {
            if (Nazivnik == 1) return brojnik.ToString();
            return $"{brojnik} / {nazivnik}";
        }

        public Razlomak Zbrajanje(Razlomak drugi_razlomak) 
        {
            double brojnik = this.brojnik * drugi_razlomak.nazivnik + this.Nazivnik*drugi_razlomak.brojnik;
            double nazivnik = this.Nazivnik * drugi_razlomak.nazivnik;

            return new Razlomak(brojnik, nazivnik);
        }
    }
}
