using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        //delegate void ShowMessageDelegate(string _message);
        //static void Main(string[] args)
        //{
        //    ShowMessageDelegate showMessageDelegate = (string mes) =>
        //    {
        //        Console.WriteLine(mes);
        //    };
        //    showMessageDelegate.Invoke("Hello World!");
        //    Console.Read();
        //}

            delegate int RandomNumberDelegate();
            static void Main(string[] args)
            {
                RandomNumberDelegate randomNumberDelegate = () => { return new Random().Next(0, 100); };
       
                int result = randomNumberDelegate.Invoke();
                Console.WriteLine(result);
                Console.Read();
            }
    }
}
