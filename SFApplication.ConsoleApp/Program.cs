using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;
            Console.WriteLine("Введите Имя");
            anketa.name = Console.ReadLine();

            Console.WriteLine("Введите Возраст");
            anketa.age =  Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine($"Имя {anketa.name}, возраст {anketa.age}");

            Console.ReadKey();


        }
    }
}
