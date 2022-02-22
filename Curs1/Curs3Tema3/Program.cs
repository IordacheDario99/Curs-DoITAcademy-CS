namespace Curs3Tema3;
public class Program
{
    public static void Main(string[] args)
    {
        Money myBalance = new Money();
        myBalance.Amount = 20;
        myBalance.Currency = "EUR";
        BankAccount myAccount = new BankAccount();
        myAccount.Balance = myBalance;
        myAccount.PrintCurrentBalance();

        myAccount.DepositAmount(10);
        myAccount.PrintCurrentBalance();
        myAccount.WithdrawAmount(100);
        myAccount.PrintCurrentBalance();
        myAccount.WithdrawAmount(15.5m);
        myAccount.PrintCurrentBalance();



    }
}