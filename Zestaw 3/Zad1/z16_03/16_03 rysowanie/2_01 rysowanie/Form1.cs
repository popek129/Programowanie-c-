using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_03_rysowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool click;
        private int px1, py1, px2, py2, px3, py3, radius, a = 0;

        private void rysujOkrag(int x, int y, int radius)
        {
            using (Graphics graphics = this.panel1.CreateGraphics())
            {
                Okrag okrag = new Okrag(x, y, radius);
                okrag.Rysuj(graphics);
            }
        }
        private void rysujTrojkat(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            using (Graphics graphics = this.panel1.CreateGraphics())
            {
                Trojkat trojkat = new Trojkat(x1, y1, x2, y2, x3, y3);
                trojkat.Rysuj(graphics);
            }
        }
        private void rysujProstokat(int x1, int y1, int x2, int y2)
        {
            using (Graphics graphics = this.panel1.CreateGraphics())
            {
                Prostokat prostokat = new Prostokat(x1, y1, x2, y2);
                prostokat.Rysuj(graphics);
            }
        }

        public void rysuj()
        {
            if (radioButton1.Checked)
                rysujOkrag(px1, py1, radius);
            else if (radioButton2.Checked)
                rysujTrojkat(px1, py1, px2, py2, px3, py3);
            else if (radioButton3.Checked)
                rysujProstokat(px1, py1, px2, py2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            rysuj();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked || radioButton3.Checked)
            {
                click = true;
                px1 = e.X;
                py1 = e.Y;
            }
            if (radioButton2.Checked)
            {
                if (a == 0)
                {
                    px1 = e.X;
                    py1 = e.Y;
                }
                else if (a == 1)
                {
                    px2 = e.X;
                    py2 = e.Y;
                }
                else if (a == 2)
                {
                    px3 = e.X;
                    py3 = e.Y;
                    panel1.Invalidate();
                }
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (click)
            {
                px2 = e.X;
                py2 = e.Y;
                if (px2 - px1 >= py2 - py1) radius = px2 - px1;
                else radius = py2 - py1;
                panel1.Invalidate();
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked || radioButton3.Checked) click = false;
            
            if (radioButton2.Checked)
            {
                if (a == 0) a = 1;
                else if (a == 1) a = 2;
                else if (a == 2) a = 0;
            }
        }
    }
}
