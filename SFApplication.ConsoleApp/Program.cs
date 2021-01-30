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

        static int PlusDivision(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {

            Sub sub = SubDivision;
            sub += PlusDivision;

            int res =  sub.Invoke(3,3);
            Console.WriteLine(res);

            Console.ReadLine();

        }
    }


    
}
