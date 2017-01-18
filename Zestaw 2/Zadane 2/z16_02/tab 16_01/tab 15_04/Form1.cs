using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tab_16_01
{
    public partial class Form1 : Form
    {
        TabWyp zmienna = new TabWyp();
        bool spr;
        int parse;

        public Form1()
        {
            InitializeComponent();
            textBox4.Text = "10";
            textBox3.Text = "1";
            textBox2.Text = "10";
            textBox1.Text = "1";
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "";
            spr = Int32.TryParse(textBox1.Text, out parse);
            if (spr) { zmienna.Row1 = parse; textBox5.Text = zmienna.Napis; }
            else textBox5.Text = "ERROR - BRAK/ZŁA LICZBA";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "";
            spr = Int32.TryParse(textBox2.Text, out parse);
            if (spr) { zmienna.Row2 = parse; textBox5.Text = zmienna.Napis; }
            else textBox5.Text = "ERROR";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "";
            spr = Int32.TryParse(textBox3.Text, out parse);
            if (spr) { zmienna.Col1 = parse; textBox5.Text = zmienna.Napis; }
            else textBox5.Text = "ERROR";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "";
            spr = Int32.TryParse(textBox4.Text, out parse);
            if (spr) { zmienna.Col2 = parse; textBox5.Text = zmienna.Napis; }
            else textBox5.Text = "ERROR";
        }
    }
}
