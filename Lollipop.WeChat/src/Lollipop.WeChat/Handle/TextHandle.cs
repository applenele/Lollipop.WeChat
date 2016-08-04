using Lollipop.WeChat.Models.ReceiveMessage;
using Lollipop.WeChat.Models.ResponseMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lollipop.WeChat.Handle
{
    public class TextHandle : IHandle<TextReceive, TextResponse>
    {
        public TextResponse Execute(TextReceive receive)
        {
            TextResponse response = new TextResponse();
            response.RootName = "xml";
            response.ToUserName = receive.FromUserName;
            response.FromUserName = receive.ToUserName;
            response.MsgType = "text";
            response.Content = "你好";
            return response;
        }
    }
}
