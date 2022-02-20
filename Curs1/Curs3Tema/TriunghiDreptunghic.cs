using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3Tema
{
    internal class TriunghiDreptunghic
    {
        public string Nume { get; set; }
        public double Cateta1 { get; set; }
        public double Cateta2 { get; set; }
        private double ipotenuza;
        private double aria = 0;
        private double perimetru = 0;

        private double CalculeazaAria()
        {
            aria = (Cateta1 * Cateta2) / 2;
            return aria;
        }

        private double Perimetru()
        {
            ipotenuza = Math.Sqrt(Math.Pow(Cateta1, 2) + Math.Pow(Cateta2, 2));
            perimetru = ipotenuza + Cateta2 + Cateta1;
            return perimetru;
        }
        public void AfiseazaAria()
        {
            Console.WriteLine($"Aria triunghiului dreptunghic {Nume} este {aria} ");
        }
        public void AfiseazaPerimetrul()
        {
            Console.WriteLine($"Perimetrul triunghiului dreptunghic {Nume} este {perimetru} ");
        }

    }
}
