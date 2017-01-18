using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_03_podatki
{
    public interface IPodatek
    {
        string Kod { get; set; }
        string Nazwa { get; set; }
        double Stawka { get; set; }
        double Oblicz(double Kwota);
    }
    class PodatekVAT
    {
        
    }
    class PodatekPIT : IPodatek
    {
        private double stawka;
        public string Kod { get { return "PIT"; } set { } }
        public string Nazwa { get { return "Podatek dochodowy od osób fizycznych"; } set { } }
        public double Stawka
        {
            get { return stawka; }
            set { stawka = value; }
        }
        public double Oblicz(double kwota)
        {
            if (kwota <= 3091) return 0;
            else if (kwota > 3091 && kwota <= 85528) return Math.Round(kwota * Stawka - 556.02, 2);
            else return Math.Round(14839.02 + (kwota - 85528) * Stawka, 2);
        }
    }
    class PodatekCIT : IPodatek
    {
        public string Kod { get { return "CIT"; } set { } }
        public string Nazwa { get { return "Podatek dochodowy od osób prawnych"; } set { } }
        public double Stawka { get { return 0.19; } set { } }
        public double Oblicz(double kwota)
        {
            return kwota * Stawka;
        }
    }
}
