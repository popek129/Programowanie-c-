using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace zad33
{
	
	public partial class MainForm : Form
	{
		Sortowanie S;
		public MainForm()
		{
			
			InitializeComponent();
			S = new Sortowanie();
			Random T = new Random();

			 double[] liczby = new double[15];
			for (int i = 0; i < 15; i++) {
				double r = T.Next(1,100)+ T.NextDouble();
				liczby[i] = r;
				listBox1.Items.Add(Convert.ToString(liczby[i]));
				
			}
			 
			
		}
		void Button1Click(object sender, EventArgs e)
		{	
			 int ccc = listBox1.Items.Count;
			 double[] ddd = new double[ccc];
			 string[] przejscie = new string[ccc];
			 for (int i = 0; i < ccc; i++) {
			 	przejscie[i] = listBox1.Items[i].ToString();
			 	ddd[i] = Convert.ToDouble(przejscie[i]);			 	
			 }
			 S.Babelkowe(ddd,listBox1);
			 
		}
		void Button2Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
					Random T = new Random();

			 double[] liczby = new double[15];
			for (int i = 0; i < 15; i++) {
				double r = T.Next(1,100)+ T.NextDouble();
				liczby[i] = r;
				listBox1.Items.Add(Convert.ToString(liczby[i]));}
		}
	
		void Button4Click(object sender, EventArgs e)
		{
		
			 int ccc = listBox1.Items.Count;
			 double[] ddd = new double[ccc];
			 string[] przejscie = new string[ccc];
			 for (int i = 0; i < ccc; i++) {
			 	przejscie[i] = listBox1.Items[i].ToString();
			 	ddd[i] = Convert.ToDouble(przejscie[i]);			 	
			 }
			 S.SelectionS(ddd,listBox1);
		}
		void Button6Click(object sender, EventArgs e)
		{
	
			 int ccc = listBox1.Items.Count;
			 double[] ddd = new double[ccc];
			 string[] przejscie = new string[ccc];
			 for (int i = 0; i < ccc; i++) {
			 	przejscie[i] = listBox1.Items[i].ToString();
			 	ddd[i] = Convert.ToDouble(przejscie[i]);			 	
			 }
			 S.QuickSort(ddd,0,ddd.Length-1);
			 for (int i = 0; i < ddd.Length; i++) {
				listBox1.Items[i]=ddd[i];
			}
		}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
	}
	
	
	
	
	public class Sortowanie
	{
		public void Babelkowe(double[] t,ListBox J)
		{
			double temp;
		for (int k = 0; k < t.Length; k++) {
    for (int i = 0; i < t.Length - 1; i++) {
        if (t[i] > t[i + 1]) {
            temp = t[i + 1];
            t[i + 1] = t[i];
            t[i] = temp;
        }
					
    }
}
			
			for (int i = 0; i < t.Length; i++) {
				J.Items[i]=t[i];
			}
			}
		public void SelectionS (double[] t,ListBox GH)
		{
		   double  temp;
		   int min;
    for (int i = 0; i < t.Length - 1; i++)
    {
        min = i;
        for (int j = i + 1; j < t.Length; j++)
            if (t[j] < t[min])
                min = j;

        
        temp = t[i];
        t[i] = t[min];
        t[min] = temp;
    }
    for (int i = 0; i < t.Length; i++) {
				GH.Items[i]=t[i];
			}
		}
		public  void QuickSort(double[] tabelka, int lewo, int prawo)
{
int i = lewo;
int j = prawo;
double pivot = tabelka[(lewo + prawo) / 2];
while (i < j)
{
while (tabelka[i] < pivot) i++;
while (tabelka[j] > pivot) j--;
if (i <= j)
{

double tmp = tabelka[i];
tabelka[i++] = tabelka[j];  
tabelka[j--] = tmp;
}
}
if (lewo < j) QuickSort(tabelka, lewo, j);
if (i < prawo) QuickSort(tabelka, i, prawo);
}
		
		
	}}
		
		
	
	

