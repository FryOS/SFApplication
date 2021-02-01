using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[]
            {
                    new ArgumentException(),
                    new OverflowException(),
                    new DirectoryNotFoundException(),
                    new DivideByZeroException(),
                    new MyExeption()

            };

            for (int i = 0; i < exceptions.Length; i++)
            {
                try
                {
                    throw exceptions[i];
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message + "\n");

                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
                catch (MyExeption ex)
                {
                    ex.MyExeptionMethod();
                }
            }
            Console.ReadLine();
        }
    }

    class MyExeption : Exception
    {
        public void MyExeptionMethod()
        {
            Console.WriteLine("Мое исключение");
        }
    }

}
