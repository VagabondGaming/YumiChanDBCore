using System;
using System.Threading.Tasks;
using YumiChanDBCore.Discord;
using YumiChanDBCore.Discord.Entities;
using YumiChanDBCore.Storage;

namespace YumiChanDBCore
{
    internal static class Program
    {
        private static async Task Main()
        {
            Unity.RegisterTypes();

            Console.WriteLine("Hiya Discord!");

            var storage = Unity.Resolve<IDataStorage>();
            var connection = Unity.Resolve<Connection>();

            await connection.ConnectAsync(new YumiChanBotConfig()
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });

            Console.ReadKey();
        }
    }
}
