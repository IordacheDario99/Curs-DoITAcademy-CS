using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3Tema
{
    public class Shape
    {
        private string nume;
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public double CalculeazaAria()
        {
            return 0;
        }
        public double CalculeazaPerimetrul()
        {
            return 0;
        }
        public void AfiseazaAria()
        {
            Console.WriteLine("Aria este: ...");
        }
        public void AfiseazaPerimetrul()
        {
            Console.WriteLine("Perimetrul este: ...");
        }
    }
}
