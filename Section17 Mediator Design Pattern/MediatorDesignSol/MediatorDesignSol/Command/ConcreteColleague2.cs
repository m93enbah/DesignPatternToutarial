using DoFactoryMediatorPro.Mediator;
using System;

namespace DoFactoryMediatorPro.Command
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(MediatorProvider mediator)
          : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague2 gets message: "

              + message);
        }
    }
}
