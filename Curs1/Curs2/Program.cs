using System;


namespace Curs2
{
    internal class Program
    {
        //enum este o colectie de constante de tip int (strict int)
        static void Main(string[] args)
        {
            int age1 = Convert.ToInt32(Console.ReadLine());//Ana
            int age2 = Convert.ToInt32(Console.ReadLine());//Maria

            if (age1 >= 18 && age2 >= 18)
            {
                Console.WriteLine("Ana si Maria sunt majore");

            }
            else if (age1 >= 18)
            {
                Console.WriteLine("Ana este majora");
            }
            else if (age2 >= 18)
            {
                Console.WriteLine("Maria este majora");
            }
            else
            {
                Console.WriteLine("Ana si Maria nu sunt majore");

            }
            int i = 3;
            for (; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            int j = 3;
            while (j <= 10)
            {
                Console.WriteLine(j);
                j += 2;
            }

            int k = 3;
            do
            {
                Console.WriteLine(k);
                k += 2;
            } while (k <= 10);
            //------------ dupa pauza ------------

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Introduceti numarul zilei: ");
            int zi = Convert.ToInt32(Console.ReadLine());

            /*if (zi == 1)
            {
                Console.WriteLine("Azi este Luni");
            }
            else if (zi == 2)
            {
                Console.WriteLine("Azi este Marti");

            }
            else if (zi == 3)
            {
                Console.WriteLine("Azi este Miercuri");

            }
            else if (zi == 4)
            {
                Console.WriteLine("Azi este Joi");

            }
            else if (zi == 5)
            {
                Console.WriteLine("Azi este Vineri");

            }
            else if (zi == 6)
            {
                Console.WriteLine("Azi este Sambata");

            }
            else if (zi == 7)
            {
                Console.WriteLine("Azi este Duminica");

            }*/
            switch (zi)
            {
                case 1:
                    Console.WriteLine("Este Luni!");
                    break;
                case 2:
                    Console.WriteLine("Este Luni!");
                    break;
                case 3:
                    Console.WriteLine("Este Luni!");
                    break;
                case 4:
                    Console.WriteLine("Este Luni!");
                    break;
                case 5:
                    Console.WriteLine("Este Luni!");
                    break;
                case 6:
                    Console.WriteLine("Este Luni!");
                    break;
                case 7:
                    Console.WriteLine("Este Luni!");
                    break;
                default:
                    Console.WriteLine($"Week! {zi} nu este o zi a saptamanii!");
                    break;
            }

            Console.WriteLine("Tema sporadnica");
            var n = Convert.ToInt32(Console.ReadLine());
            var nr = 0;
            var m = 0;

            for (int a = 9; a >= 0; a--)
            {
                m = n;
                while (m != 0 && m % 10 != a)
                    m /= 10;

                if (m != 0)
                    nr = nr * 10 + m % 10;
            }
            Console.WriteLine("@@@@ Numarul este: " + nr);


            //tema din curs exercitiul cu switch



        }
    }
}
