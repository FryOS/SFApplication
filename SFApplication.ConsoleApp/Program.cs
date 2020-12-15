using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] FavColors, double Age) User;
                Console.WriteLine("Введите Ваше имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите Вашу фамилию");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите Ваш логин");
                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у вас животное: Да или Нет?");
                var result = Console.ReadLine();
                if (result == "Да" || result == "Yes")
                    User.HasPet = true;
                else
                    User.HasPet = false;

                Console.WriteLine("Ваши любимые цвета?");
                User.FavColors = new string[3];

                for (int y = 0; y < User.FavColors.Length; y++)
                {
                    var favColor = Console.ReadLine();
                    User.FavColors[y] = favColor;
                }

                Console.WriteLine("Введите ваш возраст");
                User.Age = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Ваше имя {User.Name}");
                Console.WriteLine($"Ваша фамилия {User.LastName}");
                Console.WriteLine($"Ваш логин {User.Login}");
                Console.WriteLine($"Колличество символом в логине {User.LoginLength}");
                
                if(User.HasPet)
                    Console.WriteLine($"Питомец есть");
                else
                    Console.WriteLine($"Питомца нет");

                Console.WriteLine($"Любимые цвета:");
                foreach (var item in User.FavColors)
                {
                    Console.WriteLine($"{item}");
                }
                Console.WriteLine($"Ваш возраст {User.Age}");
            }
            Console.ReadKey();
        }
    }
}
