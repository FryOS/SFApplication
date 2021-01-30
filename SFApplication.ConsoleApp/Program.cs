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
            //Exception ex = new Exception("Мое исключение");
            //ex.Data.Add("дата создания ошибки", DateTime.Now);

            //Console.WriteLine(ex.Message);

            //ex.HelpLink = "Я помогаю";

            try
            {
                int result = Division(7, 1);

                Console.WriteLine(result);
            }

            catch (Exception ex)
            {
                if (ex is DivideByZeroException) Console.WriteLine("На ноль делить нельзя!");
                else Console.WriteLine("Произошла непредвиденная ошибка в приложении.");
            }

            finally
            {
                Console.WriteLine("Блок Finally сработал!");
            }


            Console.ReadLine();

        }
    }


    
}
