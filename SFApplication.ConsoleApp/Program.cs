using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Введите ваш возраст:");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваше имя {name} и возраст {age}");
            Console.WriteLine($"Введите дату ващего рождения");
            var birthday = Console.ReadLine();
            Console.WriteLine($"Ваша дата {birthday}");
            Console.ReadLine();
        }
    }
}
