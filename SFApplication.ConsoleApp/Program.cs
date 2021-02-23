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
            // читаем весь файл в строку 
            string text = File.ReadAllText(@"C:\Users\Alexey\source\repos\SFApplication\SFApplication.ConsoleApp\Text.txt");
            // разбиваем в массив, используя пробел в качестве разделителя
            var words = text.Split(new char[] { ' ' }).Length;

            // выводим количество
            Console.WriteLine(words);


            Console.ReadLine();
        }
    }
}
