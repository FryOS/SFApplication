using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        const string SettingsFileName = @"C:/Users/Alexey/source/repos/SFApplication/SFApplication.ConsoleApp/BinaryFile.bin";

        static void Main(string[] args)
        {
            // создание объекта класса
            var contact = new Contact("Евгений", 79991234567, "example@example.com");

            // сериализация
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream("Contact.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, contact);
            }

            Console.ReadLine();
        }
        [Serializable]
        class Contact
        {
            public string Name { get; set; }
            public long PhoneNumber { get; set; }
            public string Email { get; set; }

            public Contact(string name, long phoneNumber, string email)
            {
                Name = name;
                PhoneNumber = phoneNumber;
                Email = email;
            }
        }


    }
}
