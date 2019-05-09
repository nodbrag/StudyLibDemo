using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace MediatRDemo.publishNotification
{
    public class Hello : INotification
    {
        public int MsgId { get; set; }
    }
}
