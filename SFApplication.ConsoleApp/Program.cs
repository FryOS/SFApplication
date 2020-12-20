using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Цикл for");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
                ShowColor();
            }

            Console.WriteLine("Цикл while");
            int k = 0;
            while (k < 3)
            {
                Console.WriteLine(k);

                ShowColor();
            }

            Console.WriteLine("Цикл do");
            int t = 0;

            do
            {
                Console.WriteLine(t);

                ShowColor();

            } while (t < 3);

            Console.ReadKey();
        }

        private static void ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

            #region switch
            switch (color)            
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            #endregion
        }
    }
}
