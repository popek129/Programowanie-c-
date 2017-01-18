using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_02
{
    class Klasa
    {
        public ListBox BoxLista = new ListBox();
        public ComboBox BoxCombo = new ComboBox();
        public ListView ListaWidoku = new ListView();
        public DataGridView WidokWyniku = new DataGridView();

    
        public TextBox WysokoscTextBox = new TextBox();
        public Label WysokoscLabel = new Label();
        public TextBox SzerokoscTextBox = new TextBox();
        public Label SzerokoscLabel = new Label();
        public ComboBox ComboBox = new ComboBox();
        public Label ComboBoxLabel = new Label();
        public TextBox TextBoxPizX = new TextBox();
        public Label LabelPozX = new Label();
        public TextBox TextBoxPozY = new TextBox();
        public Label LabelPozY = new Label();
        public CheckBox Widok = new CheckBox();


        private int Ustawienia;
        public int Kontrolka
        {
            get
            {
                return Ustawienia;
;
            }
            set
            {
                Ustawienia = value;
            }
        }
        public int Wysokosc
        {
            get
            {
                return int.Parse(WysokoscTextBox.Text);
            }
            set
            {
                WysokoscTextBox.Text = value.ToString();
            }
        }
        public int Szerokosc
        {
            get
            {
                return int.Parse(SzerokoscTextBox.Text);
            }
            set
            {
                SzerokoscTextBox.Text = value.ToString();
            }
        }
        public int BackColorID
        {
            get
            {
                return ComboBox.SelectedIndex;
            }
            set
            {
                ComboBox.SelectedIndex = value;
            }
        }
        public int Pozycja_X
        {
            get
            {
                return int.Parse(TextBoxPizX.Text);
            }
            set
            {
                TextBoxPizX.Text = value.ToString();
            }
        }
        public int Pozycja_Y
        {
            get
            {
                return int.Parse(TextBoxPozY.Text);
            }
            set
            {
                TextBoxPozY.Text = value.ToString();
            }
        }
        public bool Widzialny
        {
            get
            {
                return Widok.Checked;
            }
            set
            {
                Widok.Checked = value;
            }
        }


        public void UstawDomyslne()
        {
         
            BoxLista.Location = new System.Drawing.Point(150, 400);
            BoxCombo.Location = new System.Drawing.Point(150, 400);
            ListaWidoku.Location = new System.Drawing.Point(150, 400);
            WidokWyniku.Location = new System.Drawing.Point(150, 400);

           
            WysokoscTextBox.Location = new System.Drawing.Point(50, 100);

            WysokoscLabel.Location = new System.Drawing.Point(50, 85);

           
            SzerokoscTextBox.Location = new System.Drawing.Point(50, 145);
            SzerokoscLabel.Location = new System.Drawing.Point(50, 130);

          
            ComboBox.Location = new System.Drawing.Point(50, 190);
            ComboBoxLabel.Location = new System.Drawing.Point(50, 175);

            
            TextBoxPizX.Location = new System.Drawing.Point(50, 235);
            LabelPozX.Location = new System.Drawing.Point(50, 220);

            
            TextBoxPozY.Location = new System.Drawing.Point(50, 280);
            LabelPozY.Location = new System.Drawing.Point(50, 265);

           
            Widok.Location = new System.Drawing.Point(50, 310);



          

            WysokoscLabel.Text = "Wysokość";
            SzerokoscLabel.Text = "Szerokość";
            ComboBoxLabel.Text = "Kolor Tła";
            LabelPozX.Text = "Pozycja X";
            LabelPozY.Text = "Pozycja Y";
            Widok.Text = "Widoczny";



            ComboBox.Items.Add("Biały");
            ComboBox.Items.Add("Czerwony");
            ComboBox.Items.Add("Pomarańczowy");
            ComboBox.Items.Add("Żółty");
            ComboBox.Items.Add("Zielony");
            ComboBox.Items.Add("Niebieski");
            ComboBox.Items.Add("Fioletowy");
            ComboBox.Items.Add("Czarny");
        }

        public void Zmien()
        {
            BoxLista.Height = Wysokosc;
            BoxLista.Width = Szerokosc;
            if (BackColorID > -1) BoxLista.BackColor = IdToColor(BackColorID);
            BoxLista.Left = Pozycja_X;
            BoxLista.Top = Pozycja_Y;
            BoxLista.Visible = Widzialny;
            //BoxLista


            BoxCombo.Height = Wysokosc;
            BoxCombo.Width = Szerokosc;
            if (BackColorID > -1) BoxCombo.BackColor = IdToColor(BackColorID);
            BoxCombo.Left = Pozycja_X;
            BoxCombo.Top = Pozycja_Y;
            BoxCombo.Visible = Widzialny;
            //BoxCombo


            ListaWidoku.Height = Wysokosc;
            ListaWidoku.Width = Szerokosc;
            if (BackColorID > -1) ListaWidoku.BackColor = IdToColor(BackColorID);
            ListaWidoku.Left = Pozycja_X;
            ListaWidoku.Top = Pozycja_Y;
            ListaWidoku.Visible = Widzialny;
            //Lista widoku


            WidokWyniku.Height = Wysokosc;
            WidokWyniku.Width = Szerokosc;
            if (BackColorID > -1) WidokWyniku.BackColor = IdToColor(BackColorID);
            WidokWyniku.Left = Pozycja_X;
            WidokWyniku.Top = Pozycja_Y;
            WidokWyniku.Visible = Widzialny;
            //WidokWyniku
        }

        public void WczytajWartosci()
        {
            switch (Ustawienia)
            {
                case 0:
                    {
                        WysokoscTextBox.Text = BoxLista.Height.ToString();
                        SzerokoscTextBox.Text = BoxLista.Width.ToString();
                        TextBoxPizX.Text = BoxLista.Left.ToString();
                        TextBoxPozY.Text = BoxLista.Top.ToString();
                        Widok.Checked = BoxLista.Visible;
                        break;
                    }


                case 1:
                    {
                        WysokoscTextBox.Text = BoxCombo.Height.ToString();
                        SzerokoscTextBox.Text = BoxCombo.Width.ToString();
                        TextBoxPizX.Text = BoxCombo.Left.ToString();
                        TextBoxPozY.Text = BoxCombo.Top.ToString();
                        Widok.Checked = BoxCombo.Visible;
                        break;
                    }


                case 2:
                    {
                        WysokoscTextBox.Text = ListaWidoku.Height.ToString();
                        SzerokoscTextBox.Text = ListaWidoku.Width.ToString();
                        TextBoxPizX.Text = ListaWidoku.Left.ToString();
                        TextBoxPozY.Text = ListaWidoku.Top.ToString();
                        Widok.Checked = ListaWidoku.Visible;
                        break;
                    }


                case 3:
                    {
                        WysokoscTextBox.Text = WidokWyniku.Height.ToString();
                        SzerokoscTextBox.Text = WidokWyniku.Width.ToString();
                        TextBoxPizX.Text = WidokWyniku.Left.ToString();
                        TextBoxPozY.Text = WidokWyniku.Top.ToString();
                        Widok.Checked = WidokWyniku.Visible;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

        }

        private System.Drawing.Color IdToColor(int ID)
        {
            System.Drawing.Color Zwracany = new System.Drawing.Color();
            switch (ID)
            {
                case 0:
                    {
                        Zwracany = System.Drawing.Color.White;
                        break;
                    }
                case 1:
                    {
                        Zwracany = System.Drawing.Color.Red;
                        break;
                    }
                case 2:
                    {
                        Zwracany = System.Drawing.Color.Orange;
                        break;
                    }
                case 3:
                    {
                        Zwracany = System.Drawing.Color.Yellow;
                        break;
                    }
                case 4:
                    {
                        Zwracany = System.Drawing.Color.Green;
                        break;
                    }
                case 5:
                    {
                        Zwracany = System.Drawing.Color.Blue;
                        break;
                    }
                case 6:
                    {
                        Zwracany = System.Drawing.Color.Purple;
                        break;
                    }
                case 7:
                    {
                        Zwracany = System.Drawing.Color.Black;
                        break;
                    }
                default:
                    {
                        Zwracany = System.Drawing.Color.White;
                        break;
                    }
            }
            return Zwracany;

        }


    }
}
