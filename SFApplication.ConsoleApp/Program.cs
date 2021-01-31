using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        public delegate Car DelHandler();
        delegate void LexusHandlerDel(Lexus lexus);

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

            LexusHandlerDel lexusHandler = GetCarInfo;
            lexusHandler.Invoke(new Lexus());

            Console.ReadLine();
        }

        public static void GetCarInfo(Car car)
        {
            Console.WriteLine(car.GetType());
        }

        private static void Method1()
        {

        }

    }

    class Car { }
    class Lexus : Car { }
}
