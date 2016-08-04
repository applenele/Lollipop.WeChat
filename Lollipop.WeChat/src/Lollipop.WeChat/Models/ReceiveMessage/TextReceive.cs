using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lollipop.WeChat.Models.ReceiveMessage
{
    public class TextReceive : BaseReceive
    {
        public string Content { set; get; }

        public string MsgId { set; get; }
    }
}
