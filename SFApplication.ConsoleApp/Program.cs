using System;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Semaphore sem;
            sem = Semaphore.Green;
            Console.WriteLine(sem);
        }

        
    }

    enum Semaphore : int
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }
}
