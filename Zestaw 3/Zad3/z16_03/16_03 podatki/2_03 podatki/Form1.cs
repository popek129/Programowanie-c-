using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_03_podatki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton_VAT.Checked = true;
            radioButton_VAT23.Checked = true;
        }

        private void obliczWypisz(string napis)
        {
            bool spr;
            double parse;
            spr = Double.TryParse(napis, out parse);
            if (radioButton_VAT.Checked)
            {
                IPodatek podatek;
                PodatekVAT podatekVAT = new PodatekVAT();
                
                if (radioButton_VAT23.Checked)
                {
                    
                }
                else if (radioButton_VAT8.Checked)
                {
                   
                }
                else if (radioButton_VAT5.Checked)
                {
                    
                }
            }
            if (radioButton_PIT.Checked)
            {
                PodatekPIT podatekPIT = new PodatekPIT();
                label3.Text = "Kod: " + podatekPIT.Kod + "\r\nOpis: " + podatekPIT.Nazwa;
                if (spr)
                {
                    if (parse <= 85528.02) podatekPIT.Stawka = 0.18;
                    else podatekPIT.Stawka = 0.32;
                    textBox2.Text = podatekPIT.Oblicz(parse).ToString();
                }
                else textBox2.Text = "0";
            }
            if (radioButton_CIT.Checked)
            {
                PodatekCIT podatekCIT = new PodatekCIT();
                label3.Text = "Kod: " + podatekCIT.Kod + "\r\nOpis: " + podatekCIT.Nazwa;
                if (spr) textBox2.Text = podatekCIT.Oblicz(parse).ToString();
                else textBox2.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            obliczWypisz(textBox1.Text);
        }
        private void radioButton_VAT23_CheckedChanged(object sender, EventArgs e)
        {
            obliczWypisz(textBox1.Text);
        }
        private void radioButton_VAT8_CheckedChanged(object sender, EventArgs e)
        {
            obliczWypisz(textBox1.Text);
        }
        private void radioButton_VAT5_CheckedChanged(object sender, EventArgs e)
        {
            obliczWypisz(textBox1.Text);
        }
        private void radioButton_VAT_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            obliczWypisz(textBox1.Text);
        }
        private void radioButton_PIT_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            obliczWypisz(textBox1.Text);
        }
        private void radioButton_CIT_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            obliczWypisz(textBox1.Text);
        }
    }
}
