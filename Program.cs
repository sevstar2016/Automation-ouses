using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

class Program
{
     private static TelegramBotClient client;
     static void Main(string[] args)
     {
         client = new TelegramBotClient("1615771001:AAF522v6iLHQBChZdvx-kTJ9mmxg6aubor4"); 
         client.OnMessage += BotOnMessageReceived;
         client.OnMessageEdited += BotOnMessageReceived;
         client.StartReceiving();
         Console.ReadLine();
         client.StopReceiving();
     }
     private static async void BotOnMessageReceived(object sender, MessageEventArgs messageEventArgs)
     {
        var message = messageEventArgs.Message;
        if(message?.Type == MessageType.Text)
        {
            if(message.Text == "ping")
            {
                await client.SendTextMessageAsync(message.Chat.Id, "pong");
            }
        }
     }
}
