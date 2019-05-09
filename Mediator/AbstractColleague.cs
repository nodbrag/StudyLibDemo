using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    /// <summary>
    /// 抽象同事类
    /// </summary>
    public abstract class AbstractColleague
    {
        public string Name { get; set; }
        protected AbstractMediator Mediator;
        protected AbstractColleague(AbstractMediator mediator)
        {
            Mediator = mediator;
        }
        public abstract void PrintMsg(string msg);
    }
}
