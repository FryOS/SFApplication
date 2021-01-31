using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = delegate (string str)
            {
                Console.WriteLine(str);
            };
             
             
            showMessageDelegate.Invoke("Hello World!");
            Console.Read();
        }

        static void ShowMessage(string _message)
        {
            Console.WriteLine(_message);
        }
    }
}
