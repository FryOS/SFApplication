using System;
using System.Collections.Generic;
using System.Linq;



namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>()
                {
                   1,
                   "Сергей ",
                   "Андрей ",
                   300,
                };

            var list = from p in objects
                       where p is string
                       orderby p
                        select p;
            foreach (var item in list)
            {
                Console.WriteLine(item) ;
            }

            foreach (var item in objects.Where(p => p is string).OrderBy(p => p))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }

         
    }
}
