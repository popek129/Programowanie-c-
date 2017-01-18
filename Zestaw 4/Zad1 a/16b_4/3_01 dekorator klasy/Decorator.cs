using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_04_dekorator_klasy
{
    public abstract class Pizza
    {
        public abstract string Opis();
        public abstract double Cena();
    }

    public class Mala : Pizza
    {
        private string opis = "Mała";
        private double cena = 7.5;
        public override string Opis()
        {
            return opis;
        }
        public override double Cena()
        {
            return cena;
        }
    }
    public class Srednia : Pizza
    {
        private string opis = "Średnia";
        private double cena = 11.25;
        public override string Opis()
        {
            return opis;
        }
        public override double Cena()
        {
            return cena;
        }
    }
    public class Duza : Pizza
    {
        private string opis = "Duża";
        private double cena = 15.0;
        public override string Opis()
        {
            return opis;
        }
        public override double Cena()
        {
            return cena;
        }
    }

    public abstract class Dekorator : Pizza
    {
        Pizza pizza = null;
        protected string opis;
        protected double cena;
        protected Dekorator(Pizza p)
        {
            pizza = p;
        }
        public override string Opis()
        {
            return pizza.Opis() + opis;
        }
        public override double Cena()
        {
            return pizza.Cena() + cena;
        }
    }

    class SosPomidorowy : Dekorator
    {
        public SosPomidorowy(Pizza p)
            : base(p)
        {
            opis = "\r\n\t - sos pomidorowy";
            cena = 0.0;
        }
    }
    class Ser : Dekorator
    {
        public Ser(Pizza p)
            : base(p)
        {
            opis = "\r\n\t - ser";
            cena = 1.5;
        }
    }
    class Pieczarki : Dekorator
    {
        public Pieczarki(Pizza p)
            : base(p)
        {
            opis = "\r\n\t - pieczarki";
            cena = 1.5;
        }
    }
    class Szynka : Dekorator
    {
        public Szynka(Pizza p)
            : base(p)
        {
            opis = "\r\n\t - szynka";
            cena = 2.5;
        }
    }
    class Salami : Dekorator
    {
        public Salami(Pizza p)
            : base(p)
        {
            opis = "\r\n\t - salami";
            cena = 3.0;
        }
    }
    class Oliwki : Dekorator
    {
        public Oliwki(Pizza p)
            : base(p)
        {
            opis = "\r\n\t - oliwki";
            cena = 2.0;
        }
    }

}
