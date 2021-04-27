using DoFactoryMediator2Pro.Mediator;
using System;

namespace DoFactoryMediator2Pro.Command
{
    //on this abstract class we have instnace of the Chartoom Mediator Concrete which used to call it through the child class
    class Participant
    {
        private Chatroom _chatroom;
        private string _name;

        public Participant(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public Chatroom Chatroom
        {
            set { _chatroom = value; }
            get { return _chatroom; }
        }

        // Sends message to given participant
        public void Send(string to, string message)
        {
            _chatroom.Send(_name, to, message);
        }

        // Receives message from given participant
        public virtual void Receive(
          string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'",
              from, Name, message);
        }
    }
}
