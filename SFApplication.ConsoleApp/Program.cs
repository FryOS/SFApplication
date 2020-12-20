using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Цикл for");

            string[] favColors = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);                
                favColors[i] = ShowColor();                
            }

            Console.WriteLine("Ваши цвета");
            for (int y = 0; y < favColors.Length; y++)
            {
                Console.WriteLine(favColors[y]);
            }
            Console.ReadKey();
        }

        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();
            return color;
        }
    }
}
