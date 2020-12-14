using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя");
            var name = Console.ReadLine();
            for (int i = 1; i < name.Length+1; i++)
            {
                Console.WriteLine(name[name.Length - i] );
            }
        }
    }
}
