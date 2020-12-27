using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowUser();

            Console.ReadKey();
        }

        static (string Name, string LastName, bool HasPet, string[] FavColors, double Age) EnterUser()
        {
            (string Name,
            string LastName,
            bool HasPet,
            string[] FavColors,
            double Age) User;

            Console.WriteLine("Enter your Name");
            User.Name = Console.ReadLine();

            Console.WriteLine("Enter your LastName");
            User.LastName = Console.ReadLine();


            string age;
            int intAge;
            do
            {
                Console.WriteLine("Enter your Age");
                age = Console.ReadLine();

            } while (!CheckNum(age, out intAge));

            User.Age = intAge;


            Console.WriteLine("Есть ли у вас животное: Да/Yes или Нет/No?");
            var result = Console.ReadLine().ToLower();
            if (result == "Да".ToLower() || result == "Yes".ToLower())
            {
                User.HasPet = true;
                //Console.WriteLine("Сколько питомцев?");
                string numPet;
                int intNumPet = 0;
                do
                {
                    Console.WriteLine("А Сколько питомцев?");
                    numPet = Console.ReadLine();


                } while (!CheckNum(numPet, out intNumPet));
                GetNamePet(intNumPet);
            } 
            else if (result == "Нет".ToLower() || result == "No".ToLower())
            {
                Console.WriteLine("Жалко что у вас нет питомца");
                User.HasPet = false;
            }
            else
                User.HasPet = false;

           
            string numCol;
            int range; 
            do
            {
                Console.WriteLine("Какое количество ваших любимых цветов?");
                numCol = Console.ReadLine();


            } while (!CheckNum(numCol, out range));

            User.FavColors = new string[range];
            Console.WriteLine("Назовите их");
            for (int y = 0; y < User.FavColors.Length; y++)
            {
                var favColor = Console.ReadLine();
                User.FavColors[y] = favColor;
            }

            return User;
        }

        static bool CheckNum(string number, out int corrNumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrNumber = intnum;
                    return true;
                }
            }
            corrNumber = 0;
            return false;
        }

        static string[] GetNamePet(int range)
        {
            string[] names = new string[range];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Как зовут ваших питомцев");
                string name = Console.ReadLine();
                names[i] = name;
            }
            return names;
        }

        static void ShowUser()
        {
            var User = EnterUser();

            Console.WriteLine($"Ваше имя {User.Name}");
            Console.WriteLine($"Ваша фамилия {User.LastName}");
            Console.WriteLine($"Ваш возраст {User.Age}");            
            Console.WriteLine($"У вас есть питомец {User.HasPet}");

            
        }
    }
}

