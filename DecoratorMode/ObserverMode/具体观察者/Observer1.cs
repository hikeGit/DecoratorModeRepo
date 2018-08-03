using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode
{
    class Observer1
    {
        private string name;
        //private Subject sub;
         
        public Observer1(string name)
        {
            this.name = name;
           // this.sub = sub;
        }


        public void ActionDo(string subname)
        {
            Console.WriteLine("主题发布者:{0}发布主题， 观察者:{1}执行动作",subname,name);
        }
    }
}
