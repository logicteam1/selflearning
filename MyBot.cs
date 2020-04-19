﻿using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
    
namespace LogicChatBot
{
    public class MyBot : IBot
    {
        public async Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default)
        {
            if (turnContext.Activity.Type is ActivityTypes.Message)
            {
                string userInput = turnContext.Activity.Text;
                await turnContext.SendActivityAsync($"You wrote {userInput}");
            }

        }
    }
}
