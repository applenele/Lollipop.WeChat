using Lollipop.WeChat.Models.ReceiveMessage;
using Lollipop.WeChat.Models.ResponseMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lollipop.WeChat.Handle
{
    public class SubscribeHandle : IHandle<SubscribeReceive, TextResponse>
    {
        public TextResponse Execute(SubscribeReceive receive)
        {
            TextResponse response = new TextResponse();
            response.RootName = "xml";
            response.ToUserName = receive.FromUserName;
            response.FromUserName = receive.ToUserName;
            response.MsgType = "text";
            response.Content = "欢迎关注小码编程";
            return response;
        }
    }
}
