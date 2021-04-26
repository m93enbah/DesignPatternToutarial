namespace CommandPatternPro.Commands
{
    //the invoker will call the ConcreteCommand that contains the Receiver class as below
    class Invoker
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
