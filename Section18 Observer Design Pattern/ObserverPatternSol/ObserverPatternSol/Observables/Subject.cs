using DoFactoryObserverPatternPro.Observers;
using System.Collections.Generic;

namespace DoFactoryObserverPatternPro.Observables
{
    //this Subject class will register all the observers instance that each one refer to the same Subject instance
    abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        //it will notify the Observer that something coming and not return as Mediator design pattern
        public void Notify()
        {
            foreach (Observer o in _observers)
            {
                o.Update();
            }
        }
    }
}
