using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _16_03_pokrywanie
{
    class Wykonawca
    {
        public void PracaA(string FileName)
        {
            StringBuilder sb = new StringBuilder();
            string[] lines = File.ReadAllLines(FileName);
            for (int i = 0; i < lines.Length; i++)
            {
                sb.Clear();
                for (int j = 0; j < lines[i].Length; j++)
                {
                    sb.Append(lines[i][j]);
                    sb.Append('-');
                }
                lines[i] = sb.ToString();
            }
            string FileName2 = FileName.Replace(".", "2.");
            File.WriteAllLines(FileName2, lines);
        }
        public virtual void PracaB(string FileName)
        {
            StringBuilder sb = new StringBuilder();
            string[] lines = File.ReadAllLines(FileName);
            foreach (string s in lines)
            {
                sb.Append("-----");
                sb.AppendLine(s);
            }
            string FileName2 = FileName.Replace(".", "2.");
            File.WriteAllText(FileName2, sb.ToString());
        }
    }
    class Zmiana1 : Wykonawca
    {
        new public void PracaA(string FileName)
        {
            StringBuilder sb = new StringBuilder();
            string[] lines = File.ReadAllLines(FileName);
            for (int i = 0; i < lines.Length; i++)
            {
                sb.Clear();
                for (int j = 0; j < lines[i].Length; j++)
                {
                    sb.Append(lines[i][j]);
                    sb.Append('-');
                }
                lines[i] = sb.ToString();
            }
            string FileName2 = FileName.Replace(".", "2.");
            File.WriteAllLines(FileName2, lines);
        }
        public override void PracaB(string FileName)
        {
            StringBuilder sb = new StringBuilder();
            string[] lines = File.ReadAllLines(FileName);
            for (int i = lines.Length-1; i >= 0; i--)
                sb.AppendLine(lines[i]);

            string FileName2 = FileName.Replace(".", "2.");
            File.WriteAllText(FileName2, sb.ToString());
        }
    }
    class Zmiana2 : Wykonawca
    {
        public override void PracaB(string FileName)
        {
            StringBuilder sb = new StringBuilder();
            string[] lines = File.ReadAllLines(FileName);
            foreach (string s in lines)
                sb.AppendFormat("<><>{0}<><>", s);

            string FileName2 = FileName.Replace(".", "2.");
            File.WriteAllText(FileName2, sb.ToString());
        }
    }
}
