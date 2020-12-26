using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Напишите что-то");
            //var str = Console.ReadLine();

            //Console.WriteLine("Укажите глубину эха");
            //var deep = int.Parse(Console.ReadLine());

            //Echo(str, deep);

           

            int a = PowerUp(2, 3);
            Console.WriteLine(a);

            Console.ReadKey();

        }

        static void Echo(string phrase, int deep)
        {
            var modif = phrase;

            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + deep);

            if (deep > 1)
            {
                Echo(phrase, deep - 1);
            }
        }

        static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N, --pow);
                }
            }
           
        }
    }
}

