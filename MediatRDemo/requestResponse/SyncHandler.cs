using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace MediatRDemo.requestResponse
{
    /// <summary>
    /// 如果Handler是完全同步的，可以继承RequestHandler类
    /// </summary>
    public class SyncHandler : RequestHandler<Ping, string>
    {
        protected override string Handle(Ping request)
        {
            return $"SyncHandler Pong";
        }
    }
}
