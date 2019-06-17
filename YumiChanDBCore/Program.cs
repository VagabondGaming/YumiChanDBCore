using System;
using YumiChanDBCore.Discord;
using YumiChanDBCore.Discord.Entities;

namespace YumiChanDBCore
{
    internal static class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();

            Console.WriteLine("Hiya Discord!");

            var discordBotConfig = new YumiChanBotConfig()
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };
        }
    }
}
