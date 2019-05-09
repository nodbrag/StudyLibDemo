using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    /// <summary>
    /// 具体中介者，负责同事类之间的交互，他必须清楚的知道需要交互的所有同事类的细节。
    /// </summary>
    public class Mediator : AbstractMediator
    {
        public AbstractColleague ColleagueA;
        public AbstractColleague ColleagueB;
        public override void SendMessage(string msg, AbstractColleague colleague)
        {
            if (colleague == ColleagueA)
            {
                ColleagueB.PrintMsg(msg);
            }
            else if (colleague == ColleagueB)
            {
                ColleagueA.PrintMsg(msg);
            }
        }
    }
}
