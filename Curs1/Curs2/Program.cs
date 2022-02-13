using System;


namespace Curs2
{
    internal class Program
    {
        //enum este o colectie de constante de tip int (strict int)
        static void Main(string[] args)
        {
            var p1 = new Program();
            p1.ProiectFlow4();
            //tema din curs exercitiul cu switch
        }

        public void ActivitateCurs()
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
                    Console.WriteLine("Este Marti!");
                    break;
                case 3:
                    Console.WriteLine("Este Miercuri!");
                    break;
                case 4:
                    Console.WriteLine("Este Joi!");
                    break;
                case 5:
                    Console.WriteLine("Este Vineri!");
                    break;
                case 6:
                    Console.WriteLine("Este Sambata!");
                    break;
                case 7:
                    Console.WriteLine("Este Duminica!");
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

        }

        public void ProiectFlow1()
        {
            Console.WriteLine("PROIECT FLOW_1");
            int var_a = Convert.ToInt32(Console.ReadLine());
            if (var_a % 2 == 0)
            {
                Console.WriteLine($"Numarul {var_a} este numar par!");
            }
            else
            {
                Console.WriteLine($"Numarul {var_a} este numar impar!");
            }
        }

        void ProiectFlow2()
        {
            Console.WriteLine("PROIECT FLOW_2");
            int var_a, var_b;
            Console.Write("Introduceti impartitorul: ");
            var_a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti deimpartitul: ");
            var_b = Convert.ToInt32(Console.ReadLine());
            int var_cat = 0, var_rest = 0;
            if (var_b != 0)
            {
                var_cat = var_a / var_b;
                var_rest = var_a % var_b;
            }
            Console.WriteLine($"\n{var_a} / {var_b} = C:{var_cat} R:{var_rest}");
        }

        void ProiectFlow3()
        {
            Console.WriteLine("PROIECT FLOW_3");
            Console.Write("Pownds: ");
            const float POUNT_TO_KILOS = 0.45359237f;
            float var_lbs, var_kg;
            var_lbs = Convert.ToSingle(Console.ReadLine());
            var_kg = var_lbs * POUNT_TO_KILOS;

            Console.WriteLine("\n Kilograms: " + var_kg.ToString("n2"));




        }

        void ProiectFlow4()
        {
            Console.WriteLine("PROIECT FLOW_4");
            int var_baz, var_exp, var_pow;
            Console.Write("Introduceti baza: ");
            var_baz = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti exponentul: ");
            var_exp = Convert.ToInt32(Console.ReadLine());
            var_pow = var_baz;
            for (int i = 1; i < var_exp; i++)
            {
                var_pow *= var_baz;
            }
            Console.WriteLine($"{var_baz} ^ {var_exp} = {var_pow}");

        }

        void ProiectFlow5()
        {
            Console.WriteLine("PROIECT FLOW_5");
            Console.WriteLine("Introduceti un numar: ");
            int var_n = Convert.ToInt32(Console.ReadLine());
            float var_sum = 0;
            for (int i = 1; i <= var_n; i++)
            {
                var_sum += i;
                if (i == var_n)
                {
                    var_sum /= i;
                }
            }
            Console.WriteLine(var_sum);

        }

        void ProiectFlow6()
        {
            Console.WriteLine("PROIECT FLOW_6");
            int var_a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{var_a} x {i} = {var_a * i}");
            }
        }

        void ProiectFlow7()
        {
            Console.WriteLine("PROIECT FLOW_7 Suplimentar");
            int var_rand = new Random().Next(0, 10);
            Console.WriteLine("Introduceti un numar intre 0 si 10 pentru a vedea daca sunteti norocos! ");
            int var_atempts = 0;
            sbyte flag = 0;

            while (flag == 0)
            {
                int var_guess = Convert.ToInt32(Console.ReadLine());
                var_atempts++;
                if (var_guess == var_rand)
                {
                    Console.WriteLine("Felicitari ati ghicit numarul {0} din {1} incercari! ", var_rand, var_atempts);
                    break;
                }
                else
                {
                    Console.Write("Nu ati ghicit numarul, doriti sa mai incercati [0 - DA / 1 - NU]: ");
                    flag = Convert.ToSByte(Console.ReadLine());
                }

            }
        }

        void ProiectFlow8()
        {
            Console.WriteLine("PROIECT FLOW_8 Suplimentar \nIntroduceti un numar: ");
            int var_a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= var_a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            }
        }
    }
}
