using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw16_01
{
    public class konwersja
    {
        public string bin(int dec)
        {
            int x = dec, y = dec;
            int a = 0;
            int[] tab;
            string binary = "";
            do
            {
                x /= 2;
                a++;
            } while (x != 0);
            tab = new int[a + 1];
            for (int i = 0; i < a; i++)
            {
                tab[i] = y % 2;
                y /= 2;
            }
            for (int i = a - 1; i >= 0; i--)
                binary += tab[i].ToString();
            return binary;
        }
        public string hex(int dec)
        {
            int x = dec, y = dec;
            int a = 0;
            int[] hex;
            string hexadec = "";
            do
            {
                x /= 16;
                a++;
            } while (x != 0);
            hex = new int[a + 1];
            for (int i = 0; i < a; i++)
            {
                hex[i] = y % 16;
                y /= 16;
            }
            for (int i = a - 1; i >= 0; i--)
            {
                if (hex[i] == 10) hexadec += 'A';
                else if (hex[i] == 11) hexadec += 'B';
                else if (hex[i] == 12) hexadec += 'C';
                else if (hex[i] == 13) hexadec += 'D';
                else if (hex[i] == 14) hexadec += 'E';
                else if (hex[i] == 15) hexadec += 'F';
                else hexadec += hex[i].ToString();
            }
            return hexadec;

        }
    }
}
