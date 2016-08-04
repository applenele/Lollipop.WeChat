using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lollipop.WeChat.Models.ResponseMessage
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            // this.RootName = "xml";
            this.CreateTime = (int)(DateTime.Now - DateTime.Parse("1970-1-1")).TotalSeconds;
        }

        public string RootName { get; set; }

        public string ToUserName { set; get; }

        public string FromUserName { set; get; }

        public int CreateTime { set; get; }

        public string MsgType { set; get; }
    }
}
