using DoFactoryMediator2Pro.Command;

namespace DoFactoryMediator2Pro.Mediator
{
    abstract class AbstractChatroom
    {
        public abstract void Register(Participant participant);
        public abstract void Send(
          string from, string to, string message);
    }
}
