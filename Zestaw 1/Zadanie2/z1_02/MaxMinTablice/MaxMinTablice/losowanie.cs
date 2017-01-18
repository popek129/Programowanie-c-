using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinTablice
{
    public class losowanie
    {
        double[] tabDouble;
        int[] tabInt;
        public double[] tabFinal;
        Random rnd;
        string napis;
        bool blad;
        public string tablica(int min, int max, int ilosc)
        {
            tabDouble = new double[ilosc];
            tabInt = new int[ilosc];
            tabFinal = new double[ilosc];
            rnd = new Random();
            napis = "";

            if (min >= max) { blad = true; return "ZŁY PRZEDZIAŁ"; }
            else if (ilosc == 0) { blad = true; return "BRAK ELEMENTÓW"; }
            else
            {
                for (int i = 0; i < ilosc; i++)
                {
                    tabDouble[i] = rnd.NextDouble();
                    tabInt[i] = rnd.Next(min, max);
                    tabFinal[i] = tabDouble[i] + tabInt[i];
                    napis += tabFinal[i].ToString() + "\r\n";
                }
                blad = false;
                return napis;
            }
        }
        public bool spr()
        {
            if (blad == false) return false;
            else return true;
        }
    }
}
