using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3Tema3
{
    internal class BankAccount
    {
        public Money Balance { get; set; }

        public bool HasPositiveBalance()
        {
            if (Balance.Amount < 0)
            {
                return true;
            }
            else
                return false;
        }
        private bool HasEnoughAmount(decimal money)
        {
            if (Balance.Amount >= money)
            {
                return true;
            }
            else
                return false;
        }
        public void DepositAmount(decimal money)
        {
            Balance.Amount += money;
        }
        public void WithdrawAmount(decimal money)
        {
            if (HasEnoughAmount(money))
            {
                Balance.Amount -= money;
            }
            else
            {
                Console.WriteLine($"Contul nu dispune de suma solicitat: {money}.\n Cont curent: {Balance.Amount}");
            }
        }
        public void PrintCurrentBalance()
        {
            Console.WriteLine($"Cont curent: {Balance.GetAmmountWithCurrency()}");
        }

    }
}
