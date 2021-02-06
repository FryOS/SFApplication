using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var messenger = new NewMessenger();

            ((IWhatsApp)messenger).SendMessage("IWhatsApp");
            ((IWhatsApp)messenger).SendMessage("IViber");
            

            Console.ReadLine();
        }

        
    }


    public interface IWhatsApp
    {
        void SendMessage(string message);
    }

    public interface IViber
    {
        void SendMessage(string message);
    }

    public class NewMessenger : IWhatsApp, IViber
    {
        void IWhatsApp.SendMessage(string message)
        {
            Console.WriteLine(message);
        }

        void IViber.SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

}
