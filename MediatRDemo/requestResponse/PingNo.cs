using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace MediatRDemo.requestResponse
{
    public class PingNo : IRequest
    {
        public int MsgId { get; set; }
    }
}
