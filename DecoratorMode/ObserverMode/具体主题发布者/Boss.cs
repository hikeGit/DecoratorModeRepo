using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode
{
    class Boss : Subject
    {
        private string action;
        public event Action<string> Update;

        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }
        public Boss(string name)
        {
            this.SubjectState = name;
        }

        public void Notify()
        {
            Update(SubjectState);
        }
    }
}
