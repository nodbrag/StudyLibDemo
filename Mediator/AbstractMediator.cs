using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    /// <summary>
    /// 抽象中介者
    /// </summary>
    public abstract class AbstractMediator
    {
        public abstract void SendMessage(string msg, AbstractColleague colleague);
    }
}
