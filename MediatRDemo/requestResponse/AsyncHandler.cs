using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatRDemo.requestResponse
{
    /// <summary>
    /// 为了方便，不需要CancellationToken的Handler，可以继承AsyncRequestHandler类
    /// </summary>
    public class AsyncHandler : AsyncRequestHandler<PingNo>
    {
        protected override Task Handle(PingNo request, CancellationToken cancellationToken)
        {
            return Task.FromResult("Pong");
           // return  Task.CompletedTask;
        }

    }
}
