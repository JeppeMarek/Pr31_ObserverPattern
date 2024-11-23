namespace Pr31_ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject cSub = new ConcreteSubject();
            ConcreteObserver cObs1 = new ConcreteObserver(cSub);
            ConcreteObserver cObs2 = new ConcreteObserver(cSub);

            cSub.State = 1;
            cSub.Attach(cObs1);
            cSub.Attach(cObs1);
            cObs1.Update();

        }
    }
}
