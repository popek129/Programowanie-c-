using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw16_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            konwersja bin = new konwersja();
            int ciag = Convert.ToInt16(textBox1.Text);
            label2.Text = bin.bin(ciag);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            konwersja hex = new konwersja();
            int ciag = Convert.ToInt16(textBox1.Text);
            label2.Text = hex.hex(ciag);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
