using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3Tema
{
    internal class TriunghiEchilateral
    {
        public string Nume { get; set; }
        public double Latura { get; set; }
        private double aria = 0;
        private double perimetru = 0;

        private double CalculeazaAria()
        {
            //Formula aria triunghi echilateral;
            aria = (Math.Pow(Latura, 2) * Math.Sqrt(3)) / 4;
            return aria;
        }

        private double CalculeazaPerimetrul()
        {
            perimetru = Latura * 3;
            return perimetru;
        }

        public void AfiseazaAria()
        {
            Console.WriteLine($"Aria triunghiului echilateral {Nume} este {CalculeazaAria()} ");
        }
        public void AfiseazaPerimetrul()
        {
            Console.WriteLine($"Perimetrul triunghiului echilateral {Nume} este {CalculeazaPerimetrul()} ");
        }
    }
}
