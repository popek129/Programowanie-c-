using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinTablice
{
    class operacje
    {
        public double suma, srednia, odchylenie;
        public void sumaTablicy(double[] tab)
        {
            suma = 0;
            for (int i = 0; i < tab.Length; i++)
                suma += tab[i];
        }
        public void sredniaTablicy(double[] tab)
        {
            srednia = 0;
            srednia = suma / tab.Length;
        }
        public void odchylenieTablicy(double[] tab)
        {
            double x = 0;
            for (int i = 0; i < tab.Length; i++)
                x += (tab[i] - srednia) * (tab[i] - srednia);
            odchylenie = Math.Sqrt(x / (tab.Length - 1));
        }
    }
}
