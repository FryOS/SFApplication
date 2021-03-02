using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace LinkedList
{
    class Program
    {
        private static LinkedList<string> strings = new LinkedList<string>();
        
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Alexey\source\repos\SFApplication\Text1.txt");
            var words = text.Split(new char[] { ' ' });
            var watchLinked = Stopwatch.StartNew();
            
            
            foreach (var item in words)
            {
                strings.AddFirst(item);
            }

            Console.WriteLine($"Вставка в  LinkedList: {watchLinked.Elapsed.TotalMilliseconds}  мс");

            Console.ReadLine();

        }
    }
}
