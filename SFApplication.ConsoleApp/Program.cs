using System;
using System.Collections.Generic;
using System.IO;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace SFApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new BotWorker();
            worker.Inizalize();
            worker.Start();

            Console.WriteLine("Напишите stop для прекращения работы");

            string command;
            do
            {
                command = Console.ReadLine();

            } while (command != "stop");

            worker.Stop();

            Console.ReadLine();
        }
    }

    public class BotWorker
    {
        private ITelegramBotClient botClient;

        public void Inizalize()
        {
            botClient = new TelegramBotClient(BotCredentials.BotToken);
        }

        public void Start()
        {
            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
        }

        public void Stop()
        {
            botClient.StopReceiving();
        }


        private async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Text != null)
            {
                await botClient.SendTextMessageAsync(
                chatId: e.Message.Chat, text: "Вы написали:\n" + e.Message.Text);
            }
        }
    }


    class BotCredentials
    {
        public static readonly string BotToken = "1534517938:AAEYzj1egh9SvZyh4PYU0t_mhmW5uhh_hS8";
    }
}
