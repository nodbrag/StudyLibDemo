using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using System.Threading.Tasks;

namespace MediatRDemo.requestResponse
{
    public class PingHandler : IRequestHandler<Ping, string>
    {
        public Task<string> Handle(Ping request, System.Threading.CancellationToken cancellationToken)
        {
            return Task.FromResult($"MsgID={request.MsgId},Pong");
        }
    }
}
