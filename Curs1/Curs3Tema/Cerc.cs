using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3Tema
{
    internal class Cerc
    {
        public string Nume { get; set; }
        public double Raza { get; set; }
        private double aria = 0;
        private double perimetru = 0;

        private double CalculeazaAria()
        {
            aria = Math.PI * Math.Pow(Raza, 2);
            return aria;
        }

        private double Perimetru()
        {
            perimetru = 2 * Math.PI * Raza;
            return perimetru;
        }
        public void AfiseazaAria()
        {
            Console.WriteLine($"Aria cercului {Nume} este {CalculeazaAria()} ");
        }
        public void AfiseazaPerimetrul()
        {
            Console.WriteLine($"Perimetrul cercului {Nume} este {Perimetru()} ");
        }
    }
}
