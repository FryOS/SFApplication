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
            for (int i = 1; i <= 10; i++)
            {
                var item = statistics.ElementAt(i);
                var itemKey = item.Key;
                var itemValue = item.Value;
                Console.WriteLine($"{i} \t {itemKey} \t {itemValue}");
            }
            Console.ReadLine();
        }
    }
}


//Сделал с помощью LINQ , но мы его официально еще не проходили. Я не совсем разбираюсь, но гугл в помощь мне. Получилось в итоге. Но прошу оценить правильно ли все сделал. Как сделать без LINQ не знаю, мозгом не дошел как сделать подсчет, как сравнить что такое же слово уже есть и надо сделать +1 к счетчику. Если покажете буду благодарен. 
//Еще вопрос по поводу файла. В коде у меня полный путь. Но если вы скачаете мой код, то он не запустится, как сделать для файла в папке солюшена правильно писать относительный путь до файла? Подскажите ?