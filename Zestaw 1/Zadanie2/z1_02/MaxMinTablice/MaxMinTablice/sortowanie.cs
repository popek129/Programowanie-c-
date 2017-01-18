using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinTablice
{
    class sortowanie
    {
        double tmp;
        string napis;

        public void srotPrzestawne(double[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            
                for (int j = i + 1; j < tab.Length; j++)
                
                    if (tab[i] >= tab[j])
                    {
                        tmp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = tmp;
                    }
              
           
        }
        public void sortBubble(double[] tab)
        {
            int n = tab.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);
        }
        public void quickSort(double[] tab, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = tab[(left + right) / 2];
            while (i < j)
            {
                while (tab[i] < pivot) i++;
                while (tab[j] > pivot) j--;
                if (i <= j)
                {
                    var tmp = tab[i];
                    tab[i++] = tab[j];
                    tab[j--] = tmp;
                }
                if (left < j) quickSort(tab, left, j);
                if (i < right) quickSort(tab, i, right);
            }
        }
        public string wypisz(double[] tab)
        {
            napis = "";
            for (int i = 0; i < tab.Length; i++)
                napis += tab[i] + "\r\n";
            return napis;
        }
    }
}
