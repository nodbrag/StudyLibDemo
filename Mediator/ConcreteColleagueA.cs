using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    /// <summary>
    /// 具体同事类A，他是不知道其他具体同事类的存在的。他与其他同事类的交互，是通过中介者来实现的。
    /// </summary>
    public class ConcreteColleagueA : AbstractColleague
    {
        public ConcreteColleagueA(AbstractMediator mediator) : base(mediator)
        {
        }
        public void SendMessage(string msg)
        {
            Mediator.SendMessage(msg, this);
        }
        public override void PrintMsg(string msg)
        {
            Console.WriteLine($"A收到消息：{msg}");
        }
    }
}
