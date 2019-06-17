using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;

namespace YumiChanDBCore.Discord
{
    public class DiscordLogger
    {
        ILogger _logger;

        public DiscordLogger(ILogger logger)
        {
            _logger = logger;
        }

        public Task Log(LogMessage logMessage)
        {
            _logger.Log(logMessage.Message);

            return Task.CompletedTask;
        }
    }
}
