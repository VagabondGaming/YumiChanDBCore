using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord.WebSocket;
using YumiChanDBCore.Discord.Entities;

namespace YumiChanDBCore.Discord
{
    public class Connection
    {
        private DiscordSocketClient _client;
        private DiscordLogger _logger;

        public Connection(DiscordLogger logger)
        {
            _logger = logger;
        }

        internal async Task ConnectAsync(YumiChanBotConfig config)
        {
            _client = new DiscordSocketClient();

            _client.Log += _logger.Log;

            // todo: continue
        }
    }
}
