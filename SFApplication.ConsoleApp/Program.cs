using System;
using System.Collections.Generic;
using System.IO;

namespace SFApplication.ConsoleApp
{
    public delegate void Notify(); //делегат
    // класс Издатель(вызывает события)
    public class ProcessLogic
    {
        public event Notify ProcessCompleted; //событие, метод обработчика события

        public void StartProcess()
        {
            Console.WriteLine("Process Start");
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }

    //класс подписчик
    class Program
    {
        static void Main(string[] args)
        {
            ProcessLogic processLogic = new ProcessLogic();
            processLogic.ProcessCompleted += processLogic_ProcessCompleted; // регис-ем событие
            processLogic.StartProcess();

            Console.ReadLine();
        }

        //перехватчик события
        private static void processLogic_ProcessCompleted()
        {
            Console.WriteLine("Process is over");
        }
    }

}
