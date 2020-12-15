using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] FavColors, double Age) anketa;
            Console.WriteLine("Введите Ваше имя");
            anketa.Name = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию");
            anketa.LastName = Console.ReadLine();

            Console.WriteLine("Введите Ваш логин");
            anketa.Login = Console.ReadLine();

            anketa.LoginLength = anketa.Login.Length;

            anketa.HasPet = false;

            Console.WriteLine("Ваши любимые цвета?");
            anketa.FavColors = new string[3];
           
            for (int i = 0; i < anketa.FavColors.Length; i++)
            {
                var favColor = Console.ReadLine();
                anketa.FavColors[i] = favColor;
            }

            Console.WriteLine("Введите ваш возраст");
            anketa.Age = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Ваше имя {anketa.Name}");
            Console.WriteLine($"Ваша фамилия {anketa.LastName}");
            Console.WriteLine($"Ваш логин {anketa.Login}");
            Console.WriteLine($"Колличество символом в логине {anketa.LoginLength}");
            Console.WriteLine($"Питомец {anketa.HasPet}");
            Console.WriteLine($"Любимые цвета:");
            foreach (var item in anketa.FavColors)
            {
                Console.WriteLine($"{item}");
            }            
            Console.WriteLine($"Ваш возраст {anketa.Age}");

            Console.ReadKey();


        }

    }
}
