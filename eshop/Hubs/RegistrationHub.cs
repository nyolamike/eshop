using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshop.Hubs
{
    /// <summary>
    /// This hub handles replies of registration processes
    /// </summary>
    public class RegistrationHub: Hub
    {
        public async Task SendMessage(string user, string message)
        {
            //Clients.Client()
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
