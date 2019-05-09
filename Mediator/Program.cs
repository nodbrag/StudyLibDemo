using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class Program
    {
        static  void  Main(string[] args)
        {
            var mediator = new Mediator();
            var colleagueA = new ConcreteColleagueA(mediator);
            var colleagueB = new ConcreteColleagueB(mediator);
            mediator.ColleagueA = colleagueA;
            mediator.ColleagueB = colleagueB;
            colleagueA.SendMessage("你好B，中午一起饭吧？");
            colleagueB.SendMessage("你好A，好的。");
            Console.ReadLine();
        }
    }
}
