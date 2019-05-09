using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

namespace MediatRDemo.publishNotification
{
    public class Hello1 : INotificationHandler<Hello>
    {
        public async Task Handle(Hello notification, CancellationToken cancellationToken)
        {
            await Task.Delay(3000);
            Console.WriteLine($"one{notification.MsgId},{Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
