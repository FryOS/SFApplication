using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            var rand = new Random();
            for (int i = 0; i < 15; i++)
            {   
                RandomNumberDelegate randomNumberDelegate = delegate ()
                {
                    return rand.Next(0,100);
                };
                int result = randomNumberDelegate.Invoke();
                Console.WriteLine(result);

            }
            

            Console.Read();
        }

        
    }
}
