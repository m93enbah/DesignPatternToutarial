namespace DoFactoryCommandPatternPro.Commands
{
    //this class is what we called on the Program.cs and using reciever as parameter to assign
    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) :base(receiver){}

        public override void Execute()
        {
            receiver.Action();
        }
    }
}
