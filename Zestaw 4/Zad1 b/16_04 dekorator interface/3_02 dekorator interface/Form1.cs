using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_04_dekorator_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rB_Lody.Checked = true;
            rB_sm.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IZamowienie zamowienie;
            if (rB_Lody.Checked) { zamowienie = new Lody(); Pokarz(zamowienie); }
            if (rB_Gofry.Checked) { zamowienie = new Gofry(); Pokarz(zamowienie); }
        }
        private void Pokarz(IZamowienie z)
        {
            label1.Text = Wypisz(z);
            if (rB_Lody.Checked)
            {
                if (rB_sm.Checked) { z = new SmakSmietankowy(z); label1.Text = Wypisz(z); }
                if (rB_kk.Checked) { z = new SmakKakaowy(z); label1.Text = Wypisz(z); }
                if (rB_m.Checked) { z = new SmakMieszany(z); label1.Text = Wypisz(z); }
            }
            if (cB_cp.Checked) { z = new CukierPuder(z); label1.Text = Wypisz(z); }
            if (cB_sm.Checked) { z = new BitaSmietana(z); label1.Text = Wypisz(z); }
            if (cB_cz.Checked) { z = new PolewaCzekoladowa(z); label1.Text = Wypisz(z); }
            if (cB_tr.Checked) { z = new PolewaTruskawkowa(z); label1.Text = Wypisz(z); }
            if (cB_kr.Checked) { z = new PolewaKarmelowa(z); label1.Text = Wypisz(z); }
            if (cB_ws.Checked) { z = new Wisnie(z); label1.Text = Wypisz(z); }
            if (cB_kw.Checked) { z = new Kiwi(z); label1.Text = Wypisz(z); }
            if (cB_pm.Checked) { z = new Pomarancze(z); label1.Text = Wypisz(z); }
        }
        private string Wypisz(IZamowienie z)
        {
            string start = "Twoje zamówienie:\r\n\r\n", cena = "\r\n\r\nCena: ";
            return string.Format("{2}{0}{3}{1} zł", z.Opis(), z.Cena(), start, cena);
        }

        private void rB_Gofry_CheckedChanged(object sender, EventArgs e)
        {
            gB_Smak.Enabled = false;
            cB_cp.Enabled = true;
        }
        private void rB_Lody_CheckedChanged(object sender, EventArgs e)
        {
            gB_Smak.Enabled = true;
            cB_cp.Enabled = false;
        }
    }
}
