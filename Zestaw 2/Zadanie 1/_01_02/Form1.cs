using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_02
{
    public partial class Form1 : Form
    {
        Klasa Aplikacja = new Klasa();
       


        public Form1()
        {
            InitializeComponent();
            Aplikacja.UstawDomyslne();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:         
                    {
                       Controls.Remove(Aplikacja.BoxCombo);
                       Controls.Remove(Aplikacja.ListaWidoku);
                       Controls.Remove(Aplikacja.WidokWyniku);
                       
                       Controls.Add(Aplikacja.BoxLista);
                       Controls.Add(Aplikacja.WysokoscTextBox);
                       Controls.Add(Aplikacja.WysokoscLabel);
                       Controls.Add(Aplikacja.SzerokoscTextBox);
                       Controls.Add(Aplikacja.SzerokoscLabel);
                       Controls.Add(Aplikacja.ComboBox);
                       Controls.Add(Aplikacja.ComboBoxLabel);
                       Controls.Add(Aplikacja.TextBoxPizX);
                       Controls.Add(Aplikacja.LabelPozX);
                       Controls.Add(Aplikacja.TextBoxPozY);
                       Controls.Add(Aplikacja.LabelPozY);
                       Controls.Add(Aplikacja.Widok);

                        Aplikacja.WczytajWartosci();

                        button1.Show();
                        break;
                    }
                case 1:         //dla ComboBox
                    {
                        Controls.Remove(Aplikacja.BoxLista); 
                        Controls.Remove(Aplikacja.ListaWidoku);
                        Controls.Remove(Aplikacja.WidokWyniku);

                        Controls.Add(Aplikacja.BoxCombo);
                        Controls.Add(Aplikacja.WysokoscTextBox);
                        Controls.Add(Aplikacja.WysokoscLabel);
                        Controls.Add(Aplikacja.SzerokoscTextBox);
                        Controls.Add(Aplikacja.SzerokoscLabel);
                        Controls.Add(Aplikacja.ComboBox);
                        Controls.Add(Aplikacja.ComboBoxLabel);
                        Controls.Add(Aplikacja.TextBoxPizX);
                        Controls.Add(Aplikacja.LabelPozX);
                        Controls.Add(Aplikacja.TextBoxPozY);
                        Controls.Add(Aplikacja.LabelPozY);
                        Controls.Add(Aplikacja.Widok);

                        Aplikacja.WczytajWartosci();
                        button1.Show();
                        break;
                    }
                case 2:         //dla ListView
                    {
                        Controls.Remove(Aplikacja.BoxCombo);
                        Controls.Remove(Aplikacja.BoxLista);
                        Controls.Remove(Aplikacja.WidokWyniku);

                        Controls.Add(Aplikacja.ListaWidoku);
                        Controls.Add(Aplikacja.WysokoscTextBox);
                        Controls.Add(Aplikacja.WysokoscLabel);
                        Controls.Add(Aplikacja.SzerokoscTextBox);
                        Controls.Add(Aplikacja.SzerokoscLabel);
                        Controls.Add(Aplikacja.ComboBox);
                        Controls.Add(Aplikacja.ComboBoxLabel);
                        Controls.Add(Aplikacja.TextBoxPizX);
                        Controls.Add(Aplikacja.LabelPozX);
                        Controls.Add(Aplikacja.TextBoxPozY);
                        Controls.Add(Aplikacja.LabelPozY);
                        Controls.Add(Aplikacja.Widok);

                        Aplikacja.WczytajWartosci();

                        button1.Show();
                        break;
                    }
                case 3:         //dla DataGridView
                    {
                        Controls.Remove(Aplikacja.BoxCombo);
                        Controls.Remove(Aplikacja.BoxLista);
                        Controls.Remove(Aplikacja.ListaWidoku);

                        Controls.Add(Aplikacja.WidokWyniku);
                        Controls.Add(Aplikacja.WysokoscTextBox);
                        Controls.Add(Aplikacja.WysokoscLabel);
                        Controls.Add(Aplikacja.SzerokoscTextBox);
                        Controls.Add(Aplikacja.SzerokoscLabel);
                        Controls.Add(Aplikacja.ComboBox);
                        Controls.Add(Aplikacja.ComboBoxLabel);
                        Controls.Add(Aplikacja.TextBoxPizX);
                        Controls.Add(Aplikacja.LabelPozX);
                        Controls.Add(Aplikacja.TextBoxPozY);
                        Controls.Add(Aplikacja.LabelPozY);
                        Controls.Add(Aplikacja.Widok);

                        Aplikacja.WczytajWartosci();

                        button1.Show();
                        break;
                    }
                default:
                    {
                        Controls.Remove(Aplikacja.BoxLista);
                        Controls.Remove(Aplikacja.WysokoscTextBox);
                        Controls.Remove(Aplikacja.WysokoscLabel);
                        Controls.Remove(Aplikacja.SzerokoscTextBox);
                        Controls.Remove(Aplikacja.SzerokoscLabel);
                        Controls.Remove(Aplikacja.ComboBox);
                        Controls.Remove(Aplikacja.ComboBoxLabel);
                        Controls.Remove(Aplikacja.TextBoxPizX);
                        Controls.Remove(Aplikacja.LabelPozX);
                        Controls.Remove(Aplikacja.TextBoxPozY);
                        Controls.Remove(Aplikacja.LabelPozY);
                        Controls.Remove(Aplikacja.Widok);
                        button1.Hide();
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aplikacja.Zmien();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
