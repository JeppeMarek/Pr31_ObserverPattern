using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr31_ObserverPattern
{
    public class ConcreteSubject : Subject
    {
        private int _state; 
        public int State
        {
            get { return _state; }
            set { _state = value; this.Notify(); }
        }
    }
}
