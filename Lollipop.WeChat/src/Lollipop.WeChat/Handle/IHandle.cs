using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lollipop.WeChat.Handle
{
    public interface IHandle<TReceive, TResponse>
        where TReceive : class
       where TResponse : class
    {
        TResponse Execute(TReceive receive);
    }
}
