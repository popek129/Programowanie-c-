using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_04_dekorator_interface
{
    public interface IZamowienie
    {
        string Opis();
        double Cena();
    }

    public class Lody : IZamowienie
    {
        private string opis = "Lody";
        private double cena = 3.5;
        public string Opis()
        {
            return opis;
        }
        public double Cena()
        {
            return cena;
        }
    }
    public class Gofry : IZamowienie
    {
        private string opis = "Gofer";
        private double cena = 4.5;
        public string Opis()
        {
            return opis;
        }
        public double Cena()
        {
            return cena;
        }
    }

    public abstract class Dekorator : IZamowienie
    {
        IZamowienie lody = null;
        protected string opis;
        protected double cena;
        public Dekorator(IZamowienie l)
        {
            lody = l;
        }
        public string Opis()
        {
            return lody.Opis() + opis;
        }
        public double Cena()
        {
            return lody.Cena() + cena;
        }
    }

    class SmakSmietankowy : Dekorator
    {
        public SmakSmietankowy(IZamowienie l)
            : base(l)
        {
            opis = "\r\n - smak waniliowy";
            cena = 0.0;
        }
    }
    class SmakKakaowy : Dekorator
    {
        public SmakKakaowy(IZamowienie l)
            : base(l)
        {
            opis = "\r\n - smak kakaowy";
            cena = 0.0;
        }
    }
    class SmakMieszany : Dekorator
    {
        public SmakMieszany(IZamowienie l)
            : base(l)
        {
            opis = "\r\n - smak mieszany";
            cena = 0.0;
        }
    }

    class PolewaCzekoladowa : Dekorator
    {
        public PolewaCzekoladowa(IZamowienie l)
            : base(l)
        {
            opis = "\r\n - polewa czekoladowa";
            cena = 0.5;
        }
    }
    class PolewaTruskawkowa : Dekorator
    {
        public PolewaTruskawkowa(IZamowienie l)
            : base(l)
        {
            opis = "\r\n - polewa truskawkowa";
            cena = 0.5;
        }
    }
    class PolewaKarmelowa : Dekorator
    {
        public PolewaKarmelowa(IZamowienie l)
            : base(l)
        {
            opis = "\r\n - polewa karmelowa";
            cena = 0.5;
        }
    }

    class Wisnie : Dekorator
    {
        public Wisnie(IZamowienie l)
            : base(l)
        {
            opis = "\r\n - wiśnie";
            cena = 1.5;
        }
    }
    class Kiwi : Dekorator
    {
        public Kiwi(IZamowienie l)
            : base(l)
        {
            opis = "\r\n - kiwi";
            cena = 1.5;
        }
    }
    class Pomarancze : Dekorator
    {
        public Pomarancze(IZamowienie l)
            : base(l)
        {
            opis = "\r\n - pomarancze";
            cena = 1.5;
        }
    }

    class BitaSmietana : Dekorator
    {
        public BitaSmietana(IZamowienie l)
            : base(l)
        {
            opis = "\r\n - bita śmietana";
            cena = 1.5;
        }
    }
    class CukierPuder : Dekorator
    {
        public CukierPuder(IZamowienie l)
            : base(l)
        {
            opis = "\r\n - cukier puder";
            cena = 1.5;
        }
    }
}
