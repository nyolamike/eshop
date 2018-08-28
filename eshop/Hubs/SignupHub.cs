using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshop.Hubs
{
    public class SignupHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            //Clients.Client()
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }

}
