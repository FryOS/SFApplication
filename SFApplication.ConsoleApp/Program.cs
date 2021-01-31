using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        public delegate int CalcDelegate(int a, int b);
        
        static void Main(string[] args)
        {
            CalcDelegate calcDelegate = Plus;
            int resPlus = calcDelegate.Invoke(3, 3);
            Console.WriteLine(resPlus);
            
            calcDelegate += Minus;
            int resMinus = calcDelegate.Invoke(3, 3);
            Console.WriteLine(resMinus);

            int res = calcDelegate.Invoke(3,3);
            
            Console.ReadLine();
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }

        static int Plus(int a, int b)
        {
            return a + b;
        }
    }


    
}
