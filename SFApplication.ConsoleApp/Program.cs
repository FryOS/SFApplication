using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static int Division(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            
            try
            {
                int result = Division(7, 1);

                Console.WriteLine(result);
                //throw new RankException();
                throw new ArgumentOutOfRangeException();
            }

            catch (ArgumentOutOfRangeException ex)
            {
                if (ex is DivideByZeroException) Console.WriteLine("На ноль делить нельзя!");
                else Console.WriteLine("Произошла непредвиденная ошибка в приложении.");

                if (ex is ArgumentOutOfRangeException)
                {
                    Console.WriteLine("ArgumentOutOfRangeException исключение");
                    Console.WriteLine(ex.GetType());
                }

            }

            catch (Exception ex)
            {
                if (ex is DivideByZeroException) Console.WriteLine("На ноль делить нельзя!");
                else Console.WriteLine("Произошла непредвиденная ошибка в приложении.");

                if (ex is RankException)
                {
                    Console.WriteLine("RankException исключение");
                    Console.WriteLine(ex.GetType());
                }

            }

            finally
            {
                Console.WriteLine("Блок Finally сработал!");
            }


            Console.ReadLine();

        }
    }


    
}
