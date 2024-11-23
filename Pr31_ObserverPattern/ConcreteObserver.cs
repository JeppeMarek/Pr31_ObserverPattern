using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr31_ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject cSubject = new ConcreteSubject();
        public int State
        {
            get;
            set;
        }

        public ConcreteObserver(ConcreteSubject subject)
        {
            cSubject = subject;
        }

        public override void Update()
        {
            State = cSubject.State;
            Console.WriteLine("Observer is at State {0}", State);
        }
    }
}