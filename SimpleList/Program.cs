using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleList
{
    class Program
    {
        private static List<string> strings = new List<string>();

        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Alexey\source\repos\SFApplication\Text1.txt");
            var words = text.Split(new char[] { ' ' });
            var watchLinked = Stopwatch.StartNew();

            foreach (var item in words)
            {
                strings.Add(item);
            }

            Console.WriteLine($"Вставка в List: {watchLinked.Elapsed.TotalMilliseconds}  мс");

            Console.ReadLine();
        }
    }
}
