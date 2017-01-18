using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_pliki_tekstowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DelegataOdczytu delegataOD;
        DelegataReszty delegataRE;
        DelegataZapisu delegataZP;

        private void button1_Click(object sender, EventArgs e)
        {
            delegataOD = Delegaty.odczyt;
            textBox1.Text = delegataOD();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delegataZP = Delegaty.zapis;
            delegataZP(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delegataRE = Delegaty.szyfruj;
            textBox1.Text = delegataRE(textBox1.Text, Int32.Parse(textBox2.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delegataRE = Delegaty.deszyfruj;
            textBox1.Text = delegataRE(textBox1.Text, Int32.Parse(textBox2.Text)).ToString();
        }

    }
}
