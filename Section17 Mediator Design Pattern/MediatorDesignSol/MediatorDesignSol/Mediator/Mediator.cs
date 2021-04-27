using DoFactoryMediatorPro.Command;

namespace DoFactoryMediatorPro.Mediator
{
    public abstract class MediatorProvider
    {
        public abstract void Send(string message,Colleague colleague);
    }
}
