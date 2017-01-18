using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _16_03_pokrywanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog otworz = new OpenFileDialog();
            otworz.Filter = "Text Files (.txt) | *.txt | All Files (*.*) | *.*";
            otworz.FilterIndex = 1;
            DialogResult ok = otworz.ShowDialog();

            StringBuilder napis = new StringBuilder();
            napis.Clear();

            nadpiszA(napis, otworz.FileName);
            nadpiszB(napis, otworz.FileName);
            nadpiszC(napis, otworz.FileName);

            textBox1.Text = napis.ToString();

            File.Delete(otworz.FileName.Replace(".", "2."));
        }
        private void nadpiszA(StringBuilder napis, string FileName)
        {
            Wykonawca plik = new Wykonawca();

            plik.PracaA(FileName);
            napis.AppendLine("Klasa Wykonawca\r\n\r\n   PracaA:");
            napis.AppendLine(File.ReadAllText(FileName.Replace(".", "2.")));

            plik.PracaB(FileName);
            napis.AppendLine("   PracaB:");
            napis.AppendLine(File.ReadAllText(FileName.Replace(".", "2.")));
        }
        private void nadpiszB(StringBuilder napis, string FileName)
        {
            Zmiana1 plik = new Zmiana1();

            plik.PracaA(FileName);
            napis.AppendLine("Klasa Zmiana1\r\n\r\n   PracaA:");
            napis.AppendLine(File.ReadAllText(FileName.Replace(".", "2.")));

            plik.PracaB(FileName);
            napis.AppendLine("   PracaB:");
            napis.AppendLine(File.ReadAllText(FileName.Replace(".", "2.")));
        }
        private void nadpiszC(StringBuilder napis, string FileName)
        {
            Zmiana2 plik = new Zmiana2();

            plik.PracaA(FileName);
            napis.AppendLine("Klasa Zmiana2\r\n\r\n   PracaA:");
            napis.AppendLine(File.ReadAllText(FileName.Replace(".", "2.")));

            plik.PracaB(FileName);
            napis.AppendLine("   PracaB:");
            napis.AppendLine(File.ReadAllText(FileName.Replace(".", "2.")));
        }
    }
}
