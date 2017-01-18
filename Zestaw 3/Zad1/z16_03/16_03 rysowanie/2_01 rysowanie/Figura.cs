using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_03_rysowanie
{
    class Figura
    {
        public int[] Parametry { get; set; }
        public virtual void Rysuj(Graphics g)
        {
            g.DrawString("Nie potrafię rysować, gdyż jestem zbyt prosta.",
               new Font("Arial", 16), Brushes.Red, Parametry[0], Parametry[1]);
        }
    }
    class Okrag : Figura
    {
        public Okrag(int x, int y, int radius)
        {
            Parametry = new int[] { x, y, radius };
        }
        public override void Rysuj(Graphics g)
        {
            Pen circlePen = new Pen(Brushes.Red);
            g.DrawEllipse(circlePen, Parametry[0], Parametry[1], Parametry[2], Parametry[2]);       // górny prawy róg w p o promieniu radius
        }
    }
    class Trojkat : Figura
    {
        public Trojkat(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Parametry = new int[] { x1, y1, x2, y2, x3, y3 };
        }
        public override void Rysuj(Graphics g)
        {
            Pen trianglePen = new Pen(Brushes.Green);
            g.DrawLine(trianglePen, new Point(Parametry[0], Parametry[1]), new Point(Parametry[2], Parametry[3]));  //p1 --> p2
            g.DrawLine(trianglePen, new Point(Parametry[2], Parametry[3]), new Point(Parametry[4], Parametry[5]));  //p2 --> p3
            g.DrawLine(trianglePen, new Point(Parametry[4], Parametry[5]), new Point(Parametry[0], Parametry[1]));  //p3 --> p1
        }
    }
    class Prostokat : Figura
    {
        public Prostokat(int x1, int y1, int x2, int y2)
        {
            Parametry = new int[] { x1, y1, x2, y2 };
        }
        public override void Rysuj(Graphics g)
        {
            Pen rectanglePen = new Pen(Brushes.Blue);
            g.DrawLine(rectanglePen, new Point(Parametry[0], Parametry[1]), new Point(Parametry[2], Parametry[1])); //p1 --> p2x, p1y
            g.DrawLine(rectanglePen, new Point(Parametry[0], Parametry[1]), new Point(Parametry[0], Parametry[3])); //p1 --> p1x, p2y
            g.DrawLine(rectanglePen, new Point(Parametry[2], Parametry[1]), new Point(Parametry[2], Parametry[3])); //p2x, p1y --> p2
            g.DrawLine(rectanglePen, new Point(Parametry[0], Parametry[3]), new Point(Parametry[2], Parametry[3])); //p1x, p2y --> p2
        }
    }
}
