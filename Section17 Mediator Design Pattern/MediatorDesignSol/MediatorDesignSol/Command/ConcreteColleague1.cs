using DoFactoryMediatorPro.Mediator;
using System;

namespace DoFactoryMediatorPro.Command
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(MediatorProvider mediator)
          : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague1 gets message: "

              + message);
        }
    }
}
