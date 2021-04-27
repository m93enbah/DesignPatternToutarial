using DoFactoryObserverPatternPro.Observers;
using DoFactoryObserverPatternPro.Observables;
using System;

namespace DoFactoryObserverPatternPro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();

            //register observer instances on the same ConcreteSubject (many to one relationship)
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();

            // Wait for user
            Console.ReadKey();
        }
    }
}
