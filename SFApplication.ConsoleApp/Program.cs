using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Как вас зовут?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Какая ваша фамилия?");
            //string surname = Console.ReadLine();
           

            //Console.WriteLine($"Какой ваш возраст {name}");
            //string age = Console.ReadLine();
            //Greet(name, age);


            string MyName = "Jane";
            byte MyAge = 27;
            bool HavePet = true;
            double shoeSize = 37.5;

            Console.WriteLine($"My name is {MyName}");
            Console.WriteLine($"My age is {MyAge}");
            Console.WriteLine($"Do I have a pet? {HavePet}");
            Console.WriteLine($"My shoe size is {shoeSize}");

            Console.ReadKey();


        }

        static void Greet(string name, string age)
        {
            Console.WriteLine($"Здравствуйте, {name}");
            Console.WriteLine($"Ваш возраст {age}");
        }
    }
}
