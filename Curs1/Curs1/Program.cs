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

            var p1 = new Program();
            //p1.Proiect2();
            //p1.Proiect3();
            p1.Proiect5();
        }

        public void Proiect2()
        {
            Console.WriteLine("\n\nCurs C# - Proiectul 3");
            short var_a, var_b, var_c;
            var_a = short.Parse(Console.ReadLine()); //bette DRY
            var_b = short.Parse(Console.ReadLine());
            Console.WriteLine(var_b.GetType());
            var_c = short.Parse(Console.ReadLine());
            var var_sum = Convert.ToInt16(var_c + var_b + var_a); // after summing the resulted value is sotred as an integer for the sake of performance
                                                                  // https://stackoverflow.com/questions/941584/byte-byte-int-why

            Console.WriteLine("var_a + var_b + var_c = " + var_sum + " " + var_sum.GetType() + " " + Convert.ToInt16(var_a + var_b + var_c));
            Console.WriteLine("var_a * var_b = " + var_a * var_b);
            Console.WriteLine("var_c / var_a = " + var_c / var_a);
            Console.WriteLine("var_a % var_b = " + var_a % var_b);
            Console.WriteLine("var_a new value is: " + var_a);

            bool var_d = var_a > 0 && var_b > 0 && var_c > 0;
            Console.WriteLine("var_d = " + var_d);


        }

        public void Proiect3()
        {
            Console.WriteLine("\n\nCurs C# - Optional Proiect 3");
            float l_patrat, a_patrat, p_patrat;
            float d_cerc, r_cerc, l_cerc, a_cerc;
            float r_sfera, a_sfera, v_sfera;
            Console.Write("Introduceti latura patratului: ");

            l_patrat = Convert.ToSingle(Console.ReadLine());
            p_patrat = l_patrat * 4;
            a_patrat = Convert.ToSingle(Math.Pow(l_patrat, 2));

            Console.WriteLine("Perimetrul patratului este: " + p_patrat);
            Console.WriteLine("Aria patratului este: " + a_patrat);

            Console.Write("Introduceti diamentrul cercului: ");

            d_cerc = Convert.ToSingle(Console.ReadLine());
            r_cerc = d_cerc / 2;
            l_cerc = Convert.ToSingle(2 * Math.PI * r_cerc);
            a_cerc = Convert.ToSingle(Math.PI * Math.Pow(r_cerc, 2));
            Console.WriteLine($"Aria cercului este {a_cerc} iar lungimea acestuia este {l_cerc}");

            Console.Write("Introduceti raza sferei: ");

            r_sfera = Convert.ToSingle(Console.ReadLine());
            a_sfera = Convert.ToSingle(4 * Math.PI * Math.Pow(r_sfera, 2));
            v_sfera = Convert.ToSingle((4 * Math.PI * Math.Pow(r_sfera, 3)) / 3);
            Console.WriteLine($"Aria sferei este {a_sfera} iar vlumul acesteia este {v_sfera}");
        }

        public void Proiect5()
        {
            int var_a, var_b, temp;
            Console.WriteLine("Introduceti cele doua valori a si b:");
            var_a = Convert.ToInt32(Console.ReadLine());
            var_b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Valori a si b inainte de interschimbare: a = {var_a} | b = {var_b}");
            temp = var_a;
            var_a = var_b;
            var_b = temp;
            Console.WriteLine($"Valori a si b dupa de interschimbare: a = {var_a} | b = {var_b}");

        }
    }
}
