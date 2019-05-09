using System;
using MediatR;
using System.Reflection;
using MediatRDemo.requestResponse;
using MediatRDemo.publishNotification;
using Microsoft.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace MediatRDemo
{
  

    class Program
    {
        private static IMediator BuildMediator()
        {
            var services = new ServiceCollection();

            services.AddMediatR(typeof(Program).GetTypeInfo().Assembly);
            var provider = services.BuildServiceProvider();

            return provider.GetRequiredService<IMediator>();
        }

        static async Task Main(string[] args)
        {
            await notify();

            Console.WriteLine( await getRes());
            Console.ReadLine();
        }
        public static async Task notify() {
            var mediator = BuildMediator();
            await mediator.Publish<Hello>(new Hello() { MsgId = 300 });
        }
        public static async Task<string> getRes() {
            var mediator = BuildMediator();
            
            var response = await mediator.Send(new Ping() { MsgId = 100 });
            return response;
        }
    }
}
