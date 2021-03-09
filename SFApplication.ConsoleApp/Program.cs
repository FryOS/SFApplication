using System;
using System.Collections.Generic;
using System.Linq;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 7999945059, Age = 23 },
               new Contact() { Name = "Сергей", Phone = 7999945052, Age = 20 },
               new Contact() { Name = "Иван", Phone = 7999945051 , Age = 21},
               new Contact() { Name = "Игорь", Phone = 7999945055, Age = 32 },
               new Contact() { Name = "Анна", Phone = 7999945057, Age = 40 },
               new Contact() { Name = "Василий", Phone = 7999945058, Age = 19 }
            };

            var sortContacts = contacts.OrderBy(c => c.Name).ThenBy(c => c.Age);
            foreach (var item in sortContacts)
                Console.WriteLine($"{item.Name} {item.Age}");

            Console.ReadLine();
        }
    }
    
    public class Contact
    {
        public string Name { get; set; }
        public long Phone { get; set; }
        public int Age { get; set; }
    }
}
