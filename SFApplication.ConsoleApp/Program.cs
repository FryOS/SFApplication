using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        const string SettingsFileName = @"C:/Users/Alexey/source/repos/SFApplication/SFApplication.ConsoleApp/BinaryFile.bin";

        static void Main(string[] args)
        {
            // Пишем
            //WriteValues();
            // Считываем
            ReadValues();


            Console.ReadLine();
        }

        static void WriteValues()
        {
            // Создаем объект BinaryWriter и указываем, куда будет направлен поток данных
            using (BinaryWriter writer = new BinaryWriter(File.Open(SettingsFileName, FileMode.Create)))
            {
                // записываем данные в разном формате
                writer.Write($"Файл изменен {DateTime.Now} на компьютере c ОС {Environment.OSVersion}");
            }
        }

        static void ReadValues()
        {
            float FloatValue;
            string StringValue;
            int IntValue;
            bool BooleanValue;

            if (File.Exists(SettingsFileName))
            {
                // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
                using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
                {
                   StringValue = reader.ReadString();
                }

                Console.WriteLine("Из файла считано:");
                Console.WriteLine("Строка: " + StringValue);
                
            }
        }
    }
}
