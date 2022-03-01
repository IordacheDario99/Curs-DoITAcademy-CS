using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3
{
    internal class ConvertorValutar
    {
        private double rataEuroRon = 4.96;
        public double ConvertEuroToRon(double euro)
        {
            return euro * rataEuroRon;
        }
    }
}
