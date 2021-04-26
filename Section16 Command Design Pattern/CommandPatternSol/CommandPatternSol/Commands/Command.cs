namespace DoFactoryCommandPatternPro.Commands
{
    //Command use Reciever as parameter and provide abstract method as below
    abstract class Command
    {
        protected Receiver receiver;
        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}
