using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_04_dekorator_klasy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pizza p;
            if (radioButton1.Checked) { p = new Mala(); dodatki(p); }
            else if (radioButton2.Checked) { p = new Srednia(); dodatki(p); }
            else if (radioButton3.Checked) { p = new Duza(); dodatki(p); }
        }
        private void dodatki(Pizza p)
        {
            p = new SosPomidorowy(p);
            label1.Text = wypisz(p);
            if (checkBox1.Checked) { p = new Ser(p); label1.Text = wypisz(p); }
            if (checkBox2.Checked) { p = new Pieczarki(p); label1.Text = wypisz(p); }
            if (checkBox3.Checked) { p = new Szynka(p); label1.Text = wypisz(p); }
            if (checkBox4.Checked) { p = new Salami(p); label1.Text = wypisz(p); }
            if (checkBox5.Checked) { p = new Oliwki(p); label1.Text = wypisz(p); }
        }
        private string wypisz(Pizza p)
        {
            string start = "Twoje zamówienie:\r\n\r\n", cena = "\r\n\r\nCena: ";
            return string.Format("{0}{1}{3}{2} zł", start, p.Opis(), p.Cena(), cena);
        }
    }
}


