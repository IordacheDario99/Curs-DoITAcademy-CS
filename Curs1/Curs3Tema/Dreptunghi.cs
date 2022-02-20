using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3Tema
{
    internal class Dreptunghi
    {
        public string Nume { get; set; }
        public double Lungime { get; set; }
        public double Latime { get; set; }
        private double aria = 0;
        private double perimetru = 0;

        private double CalculeazaAria()
        {
            aria = Latime * Lungime;
            return aria;
        }

        private double Perimetru()
        {
            perimetru = 2 * Lungime + 2 * Latime;
            return perimetru;
        }
        public void AfiseazaAria()
        {
            Console.WriteLine($"Aria dreptunghiului {Nume} este {CalculeazaAria()} ");
        }
        public void AfiseazaPerimetrul()
        {
            Console.WriteLine($"Perimetrul dreptunghiului {Nume} este {Perimetru()} ");
        }

    }
}
