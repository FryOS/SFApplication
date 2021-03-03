using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // читаем весь файл в строку 
            string text = File.ReadAllText(@"C:\Users\Alexey\source\repos\SFApplication\SFApplication.ConsoleApp\Text_Task2.txt");
            // разбиваем в массив, используя пробел в качестве разделителя

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            noPunctuationText = noPunctuationText.Replace('\n', ' ');
            while (noPunctuationText.Contains("  "))
            {
                noPunctuationText = noPunctuationText.Replace("  ", " ");
            }
            var words = noPunctuationText.Split(' ');

            Dictionary<string, int> statistics = words.GroupBy(word => word).ToDictionary(kvp => kvp.Key, kvp => kvp.Count())
            .OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            // выводим количество
            Console.WriteLine("Первые 10 самых встречаемых слов\n");
            for (int i = 0; i < 10; i++)
            {
                var item = statistics.ElementAt(i);
                var itemKey = item.Key;
                var itemValue = item.Value;
                Console.WriteLine($"{itemKey} \t {itemValue}");
            }
            Console.ReadLine();
        }
    }
}
