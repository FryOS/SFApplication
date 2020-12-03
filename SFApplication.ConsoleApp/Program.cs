using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\tПривет,\nмир!");

            //int age = 27;
            //string name = "Jane";
            //string favcolor = "black";
            //Console.WriteLine("{0}\n {1} \n{2}", name, age, favcolor);
            //Console.WriteLine($"Мой возраст {age}");
            //Console.WriteLine("Как вас зовут?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Какая ваша фамилия?");
            //string surname = Console.ReadLine();


            //Console.WriteLine($"Какой ваш возраст {name}");
            //string age = Console.ReadLine();
            //Greet(name, age);
            //string str = Console.ReadLine();
            //double result = 5 / 2 * 3;


            byte Myage = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine(Myage);
        }

        static void Greet(string name, string age)
        {
            Console.WriteLine($"Здравствуйте, {name}");
            Console.WriteLine($"Ваш возраст {age}");
            Console.ReadKey();            
        }
    }
}
