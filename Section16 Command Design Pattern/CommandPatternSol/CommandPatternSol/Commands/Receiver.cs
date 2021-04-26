using System;

namespace CommandPatternPro.Commands
{
    //this class represnt the command that we want to operate 
    //1-we use it as parameter on the Command abstract class
    //2-we using it also on the ConcreteCommand child class that inherit from Command abstract class
    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }
    }
}
