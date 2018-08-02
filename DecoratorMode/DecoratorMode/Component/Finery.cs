using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
   public    class Finery : Person
    {
        protected Person component;

        public void Decorate(Person person)
        {
            component = person;
        }

        public override void Show()
        {
            if(component !=null)
            {
                component.Show();
            }
        }
    }
}
