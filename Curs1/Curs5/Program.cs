namespace Curs5
{
    public class Program
    {
        public static void Main(string [] args)
        {
            Calculator calc = new Calculator();
            //method overloading
            int sum1 = calc.CalculeazaSuma(1, 4);
            int suma2 = calc.CalculeazaSuma(1, 4, 5);
        }
    }
}