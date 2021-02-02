using System;
using DSharpPlus;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace message_bt
{
    class Program
    {
        static DiscordClient discord;
        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        private static async Task MainAsync(string[] args)
        {
            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "",
                TokenType= TokenType.Bot
            });

            discord.MessageCreated += async e =>
             {
              
             };


        }




    }
}
