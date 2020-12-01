using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();

            Console.WriteLine("Какая ваша фамилия?");
            string surname = Console.ReadLine();
           

            Console.WriteLine($"Какой ваш возраст {name}");
            string age = Console.ReadLine();
            Greet(name, age);
        }

        static void Greet(string name, string age)
        {
            Console.WriteLine($"Здравствуйте, {name}");
            Console.WriteLine($"Ваш возраст {age}");
        }
    }
}
