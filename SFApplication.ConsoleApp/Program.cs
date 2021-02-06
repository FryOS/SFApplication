using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWriter writer = new FileManager();
            IReader reader = new FileManager();
            IMailer mailer = new FileManager();

            writer.WriteFile("writer");
            reader.ReadFile("reader");
            mailer.SendFile("mailer");

            Console.ReadLine();
        }

        
    }


    public interface IWriter
    {
        void WriteFile(string message);
    }
    public interface IReader
    {
        void ReadFile(string message);
    }
    public interface IMailer
    {
        void SendFile(string message);
    }

    public class FileManager : IWriter, IReader, IMailer
    {
        void IReader.ReadFile(string message)
        {
            Console.WriteLine(message);
        }

        void IMailer.SendFile(string message)
        {
            Console.WriteLine(message);
        }

        void IWriter.WriteFile(string message)
        {
            Console.WriteLine(message);
        }
    }

}
