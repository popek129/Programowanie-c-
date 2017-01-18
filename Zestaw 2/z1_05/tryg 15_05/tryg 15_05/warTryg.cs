using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryg_16_02
{
    class warTryg
    {
        private double angle0, angle1, deltaAngle;
        private string napis;

        public string Napis
        {
            get { return napis; }
            set { napis = value; }
        }
        public double Angle0
        {
            get { return angle0; }
            set { angle0 = value; napis = ""; oblicz(); }
        }
        public double Angle1
        {
            get { return angle1; }
            set { angle1 = value; napis = ""; oblicz(); }
        }
        public double DeltaAngle
        {
            get { return deltaAngle; }
            set { deltaAngle = value; napis = ""; oblicz(); }
        }

        private void oblicz()
        {
            double od = angle0 * Math.PI / 180;
            double doo = angle1 * Math.PI / 180;
            double przyrost = deltaAngle * Math.PI / 180;
            if (przyrost == 0) napis = "ERROR";
            else
            {
                int wielkosc = Convert.ToInt32(((doo - od) / przyrost) + 1);
                double i = od;
                int j = 0, round = 4;
                while (i <= doo)
                {
                    double sin = Math.Round(Math.Sin(i), round);
                    double cos = Math.Round(Math.Cos(i), round);
                    double tg = Math.Round(sin / cos, round);
                    double ctg = Math.Round(cos / sin, round);

                    wypisz(sin, cos, tg, ctg, i);

                    i += przyrost;
                }
            }
        }

        private string wypisz(double t1, double t2, double t3, double t4, double i)
        {
            napis += String.Format("x= {0}\t\t{1}\t\t\t{2}\t\t\t{3}\t\t\t{4}\r\n",Math.Round(i * 180 / Math.PI, 1), t1, t2, t3, t4);
            return napis;
        }
    }
}