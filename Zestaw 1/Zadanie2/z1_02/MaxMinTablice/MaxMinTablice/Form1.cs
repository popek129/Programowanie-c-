using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxMinTablice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        losowanie tablica = new losowanie();
        sortowanie sort = new sortowanie();
        operacje operacja = new operacje();

        private void text()
        {
            if (textBox1.Text == "") textBox1.Text = "10";
            if (textBox2.Text == "") textBox2.Text = "0";
            if (textBox3.Text == "") textBox3.Text = "1";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            text();

            int min = int.Parse(textBox2.Text);
            int max = int.Parse(textBox3.Text);
            int ilosc = int.Parse(textBox1.Text);

            textBox4.Text = tablica.tablica(min, max, ilosc);

            if (tablica.spr() == false)
            {
                double Wmax = tablica.tabFinal.Max();
                double Wmin = tablica.tabFinal.Min();
                sort.quickSort(tablica.tabFinal, 0, tablica.tabFinal.Length-1);
                operacja.sumaTablicy(tablica.tabFinal);
                operacja.sredniaTablicy(tablica.tabFinal);
                operacja.odchylenieTablicy(tablica.tabFinal);

                label5.Text = "Max: " + Wmax.ToString();
                label1.Text = "Min: " + Wmin.ToString();
                textBox5.Text = sort.wypisz(tablica.tabFinal);
                label7.Text = "Suma: " + operacja.suma.ToString();
                label8.Text = "Średnia: " + operacja.srednia.ToString();
                label9.Text = "Odchylenie:\r\n" + operacja.odchylenie.ToString();
            }
            else { label5.Text = "Max: "; label1.Text = "Min: "; }
        }
    }
}
