using DoFactoryMediator2Pro.Command;
using System.Collections.Generic;

namespace DoFactoryMediator2Pro.Mediator
{
    //on the Concrete Mediator we have two methods Register which register the Participant inside the Dictionary<string,Participatn> internally
    //and the another is send which used to send to target
    class Chatroom : AbstractChatroom
    {
        private Dictionary<string, Participant> _participants =
          new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            //it will assign the new Participant on the Mediator 
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }
            //it will assign the Chatromm with the instance itself
            participant.Chatroom = this;
        }

        public override void Send(
          string from, string to, string message)
        {
            Participant participant = _participants[to];

            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}
