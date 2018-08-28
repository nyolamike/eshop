using eshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshop.Messages.Registration
{
    public class RegisterShop_
    {
        public Register Model { get; }
        public string ChannelID { get; set; }

        public RegisterShop_(Register model, string channelID)
        {
            this.Model = model;
            this.ChannelID = channelID;
        }
    }
}
