using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4Tema
{
    internal class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public Money()
        {
            Amount = 0;
            Currency = "RON";
        }
        public Money(decimal ammount, string currency = "EUR")
        {
            Amount = ammount;
            Currency = currency;
            Console.WriteLine($"I have been created with the folowing values: " +
                $"{Amount}, {Currency}");
        }

        public string GetAmountWithCurrency()
        {
            return Amount + " " + Currency;
        }
    }

}
