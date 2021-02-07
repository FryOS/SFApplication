using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static ILogger Logger { get; set; }
        
        static void Main(string[] args)
        {
            Logger = new ClassLogger();

            var calc = new Greeting(Logger);
            calc.ShowMessage();
            int number1 = calc.GetNumber();
            int number2 = calc.GetNumber();
            

            var plus = new Calculator();

            var result = ((ICalcPlus)plus).Plus(number1, number2);
            Console.WriteLine($"Результат сложения = {result}");

            Console.WriteLine("Нажмите любую кнопку для выхода");
            Console.ReadLine();
        }
    }


    public interface ILogger
    {
        void Error();
        void Event();
    }

    public interface ICalcPlus
    {
        int Plus(int number1, int number2);
    }

    public class Calculator : ICalcPlus
    {
        int ICalcPlus.Plus(int number1, int number2)
        {
            return number1 + number2;
        }
    }

    public class Greeting
    {
        ILogger Logger { get; }

        public Greeting(ILogger logger)
        {
            Logger = logger;
        }
        
        public void ShowMessage()
        {
            Console.WriteLine("Этот калькулятор умеет складывать числа");
        }

        public int GetNumber()
        {
            try
            {
                Console.WriteLine("Введите число");
                Logger.Event();
                int number = Convert.ToInt32(Console.ReadLine());
                Logger.Event();
                return number;
            }

            catch (Exception ex)
            {
                Logger.Error();
                Console.WriteLine("Вы ввели строку. Число равно 0");
                Logger.Error();
                return 0;
            }
        }
    }

    public class ClassLogger : ILogger
    {
        public void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void Event()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
