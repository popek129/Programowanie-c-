using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tab_16_01
{
    class TabWyp
    {
        private int row1, row2, col1, col2;
        public int Row1
        {
            get { return row1; }
            set { row1 = value; oblicz(); }
        }
        public int Row2
        {
            get { return row2; }
            set { row2 = value; oblicz(); }
        }
        public int Col1
        {
            get { return col1; }
            set { col1 = value; oblicz(); }
        }
        public int Col2
        {
            get { return col2; }
            set { col2 = value; oblicz(); }
        }

        private string napis;
        public string Napis
        {
            get { return napis; }
            set { napis = value; }
        }

        private int[] tabela;

        private bool spr;

        private void oblicz()
        {
            
            warunek();
            if (spr)
            {
                int z = row1, x = col1;
                tabela = new int[(row2 - row1 + 1) * (col2 - col1 + 1)];
                for (int i = 0; i < tabela.Length; i++)
                {
                    if (x != col2)
                        tabela[i] = x++ * z;
                    else { tabela[i] = x++ * z++; x = col1; }
                }
                wypisz();
            }
            else napis = "ERROR - ZŁY PRZEDZIAŁ";
        }
        private string wypisz()
        {
            int licznik = col1;
            int z = row1;
            napis = "\t  K >\t";
            for (int i = col1; i <= col2; i++)
                napis += i + "\t";
            napis += "\r\n    W\\/\t";
            napis += "\r\n";
            foreach (var ob in tabela)
            {
                if (licznik == col1) napis += z++ + "\t\t";
                if (licznik == col2) { napis += ob + "\r\n"; licznik = col1; }
                else { napis += ob + "\t"; licznik++; }
            }
            return napis;
        }
        private void warunek()
        {
            if (row2 < row1 || col2 < col1) spr = false;
            else spr = true;
        }
    }
}
