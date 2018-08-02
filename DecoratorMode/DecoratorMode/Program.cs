using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    class Program
    {
        static void Main(string[] args)
        {
            //每一个concrete类都有一个component成员变量（继承自finery类），调用base.show()实际上是调用component 变量的show函数
            //基类finery是核心类，component变量是核心变量，其变量类型为finery父类
            Person person = new Person("Hello");

            Console.WriteLine("\n第一种装扮:");
            TShirt tShirt = new TShirt();
            BigTrousers trousers = new BigTrousers();
            Snearkers neark = new Snearkers();

            trousers.Decorate(tShirt);
            tShirt.Decorate(neark);
            neark.Decorate(person);
            trousers.Show();

            Console.WriteLine("\n第二种装扮:");
            trousers.Decorate(person);
            tShirt.Decorate(trousers);
            neark.Decorate(tShirt);
            neark .Show();


            Console.ReadKey();
        }
    }
}
