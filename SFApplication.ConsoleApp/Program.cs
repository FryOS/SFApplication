using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        public delegate int Sub(int a, int b);
        static int SubDivision(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {

            Sub sub = SubDivision;

            int a = sub.Invoke(5, 2);
            Console.WriteLine(a);

            Console.ReadLine();

        }
    }


    
}
