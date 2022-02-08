using System;


namespace Curs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var_a;
            bool var_b = true;
            float var_c = 1.25f;
            short var_d = 4000; //short can hold a maximum value of 32.767 thus the value 40.000 will generate an error
            uint var_ud = 120;  //if i wouldn't have commented the line 13, the compiler would've generated an error because another variable 
                                //is using that name. An uint type variable cannot hold a negative value
            long var_e = 10, var_f, var_g = 11;
            bool var_h = false; char var_i = 'B';

            Console.WriteLine("Curs C# - Proiectul 2");
            var_a = -5;
            Console.WriteLine("var_a = " + var_a);
            var_b = var_a > 0;
            Console.WriteLine("var_a > 0" + var_b);
            var_a += 20;
            var_a /= 6;
            Console.WriteLine("var_a = " + var_a);
            var_c *= var_a;
            Console.WriteLine("var_c = " + var_c);
        }
    }
}
