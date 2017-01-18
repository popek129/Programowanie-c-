using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryg_16_02
{
    public partial class Form1 : Form
    {
        warTryg wartosc = new warTryg();
        bool spr;
        double parse;

        public Form1()
        {
            InitializeComponent();
            textBox3.Text = "1";
            textBox1.Text = "0";
            textBox2.Text = "360";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "";
            spr = Double.TryParse(textBox1.Text, out parse);
            if (spr)
            {
                wartosc.Angle0 = Convert.ToDouble(textBox1.Text);
                textBox4.Text = wartosc.Napis;
            }
            else textBox4.Text = "ERROR";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "";
            spr = Double.TryParse(textBox2.Text, out parse);

            if (spr)
            {
                wartosc.Angle1 = Convert.ToDouble(textBox2.Text);
                textBox4.Text = wartosc.Napis;
            }
            else textBox4.Text = "ERROR";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "";
            spr = Double.TryParse(textBox3.Text, out parse);
            if (spr)
            {
                wartosc.DeltaAngle = Convert.ToDouble(textBox3.Text);
                textBox4.Text = wartosc.Napis;
            }
            else textBox4.Text = "ERROR";
        }
    }
}
