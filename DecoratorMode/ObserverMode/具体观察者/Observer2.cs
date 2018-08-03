using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//可以再去定义一个抽象类
namespace ObserverMode
{
    class Observer2
    {
        private string name;
       // private Subject sub;

        public Observer2(string name/*, Subject sub*/)
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
