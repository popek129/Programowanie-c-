using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace _4_pliki_tekstowe
{
    public delegate string DelegataOdczytu();
    public delegate void DelegataZapisu(string s);
    public delegate string DelegataReszty(string s, int i);

    public class Delegaty
    {
        public static string odczyt()
        {
            OpenFileDialog odczyt = new OpenFileDialog();
            odczyt.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            odczyt.FilterIndex = 1;
            DialogResult ok = odczyt.ShowDialog();
            string napis = File.ReadAllText(odczyt.FileName);
            return napis;
        }
        public static void zapis(string napis)
        {
            SaveFileDialog zapisz = new SaveFileDialog();
            zapisz.Filter = "Pliki tekstowe *.txt | *.txt | Wszystkie pliki *.* | *.*";
            zapisz.FilterIndex = 1;
            DialogResult ok = zapisz.ShowDialog();
            StreamWriter plik = new StreamWriter(zapisz.FileName);
            plik.Write(napis);
            plik.Close();
        }
        public static string szyfruj(string napis, int wsp)
        {
            string kod = "";
            char[] znak = new char[napis.Length];
            napis.ToCharArray();
            for (int i = 0; i < napis.Length; i++)
            {
                znak[i] = napis[i];
                przesun(znak, wsp, i);
                kod += znak[i].ToString();
            }
            return kod;
        }
        public static string deszyfruj(string napis, int wsp)
        {
            string kod = "";
            char[] znak = new char[napis.Length];
            napis.ToCharArray();
            for (int i = 0; i < napis.Length; i++)
            {
                znak[i] = napis[i];
                przesun(znak, 26-wsp, i);
                kod += znak[i].ToString();
            }
            return kod;
        }
        private static void przesun(char[] tab, int ilosc, int i)
        {
            if (tab[i] >= 97 && tab[i] <= 122)
            {
                tab[i] = (char)(tab[i] + ilosc);
                if (tab[i] > 122) tab[i] = (char)(tab[i] - 26);
            }
            if (tab[i] >= 65 && tab[i] <= 90)
            {
                tab[i] = (char)(tab[i] + ilosc);
                if (tab[i] > 90) tab[i] = (char)(tab[i] - 26);
            }
        }
    }
}
