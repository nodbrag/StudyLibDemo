using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ConcreteColleagueB : AbstractColleague
    {
        public ConcreteColleagueB(AbstractMediator mediator) : base(mediator)
        {
        }
        public void SendMessage(string msg)
        {
            Mediator.SendMessage(msg, this);
        }
        public override void PrintMsg(string msg)
        {
            Console.WriteLine($"B收到消息：{msg}");
        }
    }
}
