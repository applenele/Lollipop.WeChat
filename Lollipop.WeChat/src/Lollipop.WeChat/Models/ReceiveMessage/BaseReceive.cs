using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lollipop.WeChat.Models.ReceiveMessage
{
    public class BaseReceive
    {
        public string ToUserName { set; get; }

        public string FromUserName { set; get; }

        public int CreateTime { set; get; }

        public string MsgType { set; get; }

        public override string ToString()
        {
            return ToUserName + "-" + FromUserName;
        }
    }
}
