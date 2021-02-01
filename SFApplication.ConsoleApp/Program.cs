using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример
            //var lastNames = new string[5] { "Ostin", "Newel", "Patisson", "Hotter", "Wuizly" };

            SortLastNameReader nameReader = new SortLastNameReader();
            nameReader.LastNameReaderEvent += ShowNumber;

            try
            {
                nameReader.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            Console.WriteLine("-----------------");
            Console.WriteLine("Просто перечисление исключений");
            IterationExeption.IterationExeptionMethod();

            Console.ReadLine();
        }

        static void ShowNumber(int number, string[] arr)
        {
            switch (number)
            {
                case 1:
                    SortLastNameReader.SortAZ(arr);
                    Console.WriteLine("Entered 1");
                    ShowArr(arr);  break;
                case 2:
                    SortLastNameReader.SortZA(arr);
                    Console.WriteLine("Entered 2");
                    ShowArr(arr); break;
            }
        }

        static void ShowArr(string[] arr)
        {
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
        }
    }


    public static class IterationExeption
    {
        public static void IterationExeptionMethod()
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
        }
    }

    public class MyExeption : Exception
    {
        public void MyExeptionMethod()
        {
            Console.WriteLine("Введите цифру 1 или 2");
        }
    }
}
