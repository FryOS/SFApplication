using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        public delegate Car DelHandler();

        public static Car CarHandler()
        {
            return null;
        }

        public static Lexus LexusHandler()
        {
            return null;
        }


        static void Main(string[] args)
        {
            DelHandler delHandler = CarHandler;

            Console.ReadLine();
        }

        private static void Method1()
        {

        }

    }

    class Car { }
    class Lexus : Car { }
}
