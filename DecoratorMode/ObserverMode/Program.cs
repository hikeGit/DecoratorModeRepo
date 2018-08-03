using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss sub1 = new Boss("老板");
            Secratery sub2 = new Secratery("秘书");
            Observer1 obs1 = new Observer1("炒股者");
            Observer2 obs2 = new Observer2("NBA看球者");

            sub1.Update += obs1.ActionDo;
            sub1.Update += obs2.ActionDo;
            sub2.Update += obs1.ActionDo;
            sub2.Update += obs2.ActionDo;

            sub1.Notify();
            sub2.Notify();
            Console.Read();
        }
    }
}
