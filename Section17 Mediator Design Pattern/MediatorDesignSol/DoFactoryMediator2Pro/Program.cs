using DoFactoryMediator2Pro.Command;
using DoFactoryMediator2Pro.Mediator;
using System;

namespace DoFactoryMediator2Pro
{
    //so the operation is working as below 
    //the Participant child classes will send the message to the concrete mediator and this will call the recieving method inside child class
    //this way provide benefits of assign the Participant class into the Concrete Mediator 
    class Program
    {
        static void Main(string[] args)
        {
            // Create chatroom
            Chatroom chatroom = new Chatroom();

            // Create participants and register them
            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");

            //register the Participant childs
            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Chatting participants , it will send from the Participant instance to the Chatroom instnace 
            //and it will call recieve method from the Participant to the child instnace of the participants
            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");

            // Wait for user
            Console.ReadKey();
        }
    }
}
