using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("How many ? Count");
            var count = Convert.ToInt32(Console.ReadLine());
            User[] users = new User[count];
            for (int i = 0; i < count; i++)
            {
                var r = rnd.Next(0, 2);
                string name = i + "name";
                string login = i + "login";              
                users[i] = new User(login, name, Convert.ToBoolean(r));
            }

            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine($"Hello {users[i].Name}");
                if (users[i].IsPremium == false)
                    ShowAds(users[i].Name);
                else
                    Console.WriteLine($"Привет, {users[i].Name} у вас куплена подписка");
            }
            
            Console.ReadLine();
        }


        static void ShowAds(string name)
        {
            Console.WriteLine();
            Console.WriteLine($"Привет {name}");
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }

    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User(string login, string name, bool isPremiun)
        {
            this.Login = login;
            this.Name = name;
            this.IsPremium = isPremiun;
        }
    }
}
