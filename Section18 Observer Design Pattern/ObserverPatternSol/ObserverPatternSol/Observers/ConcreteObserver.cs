using DoFactoryObserverPatternPro.Observables;
using System;
namespace DoFactoryObserverPatternPro.Observers
{
    //the concrete observer contains the ConcreteSubject which is the same instnace the register it from ConcreteSubject Attach
    class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        private ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this._subject = subject;
            this._name = name;
        }

        //it will called from the Concrete Subject that broadcast all the child observers
        public override void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}", _name, _observerState);
        }

        // Gets or sets subject
        public ConcreteSubject Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}
