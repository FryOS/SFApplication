using System;
using System.Collections;
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
            // читаем весь файл в строку 
            string text = File.ReadAllText(@"C:\Users\Alexey\source\repos\SFApplication\SFApplication.ConsoleApp\Text.txt");
            // разбиваем в массив, используя пробел в качестве разделителя
            var words = text.Split(new char[] { ' ' }).Length;

            // выводим количество
            Console.WriteLine(words);

            var months = new[]
            {
               "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            var numbers = new[]
            {
               1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12
            };

            // инициализация ArrayList
            var combinedList = new ArrayList();

            //  пробегаемся по массиву чисел
            foreach (var number in numbers)
            {
                // добавляем в ArrayList строку месяца (начинаем с нулевого по индексу)
                combinedList.Add(months[number - 1]);

                // добавляем его порядковый номер
                combinedList.Add(number);
            }

            //foreach (var value in combinedList)
            //    Console.WriteLine(value);
            
            var phoneBook = new List<Contact>();
            AddUnique(new Contact("alex", 8888, "alex@oa.ru"), phoneBook);

            
            

            Console.ReadLine();

        }

        static void AddUnique(Contact newContact, List<Contact> phoneBook)
        {
            bool alreadyExists = false;

            // пробегаемся по списку и смотрим, есть ли уже с таким именем
            foreach (var contact in phoneBook)
            {
                if (contact.Name == newContact.Name)
                {
                    //  если вдруг находим  -  выставляем флаг и прерываем цикл
                    alreadyExists = true;
                    break;
                }
            }

            if (!alreadyExists)
                phoneBook.Add(newContact);

            //  сортируем список по имени
            phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

            foreach (var contact in phoneBook)
                Console.WriteLine(contact.Name + ": " + contact.PhoneNumber);
        }



        public class Contact // модель класса
        {
            public Contact(string name, long phoneNumber, String email) // метод-конструктор
            {
                Name = name;
                PhoneNumber = phoneNumber;
                Email = email;
            }

            public String Name { get; }
            public long PhoneNumber { get; }
            public String Email { get; }
        }
    }
}
