using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lollipop.WeChat.Models.ReceiveMessage
{
    public class SubscribeReceive:BaseReceive
    {
        public string Event { set; get; }
    }
}
