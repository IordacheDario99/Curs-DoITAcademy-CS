using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3Tema3
{
    internal class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public string GetAmmountWithCurrency()
        {
            return Amount + " " + Currency;
        }
        public void MultiplyAmount(double multipler)
        {
            Amount *= Convert.ToDecimal(multipler);
        }
    }
}
