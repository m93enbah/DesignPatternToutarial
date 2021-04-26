using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DoFactoryChainOfResp.Handlers
{
    public class Handler
    {
        protected int request;
        private ICollection<Handler> handlers;

        public Handler() 
        {
            handlers = new Collection<Handler>();
        }

        public void Register(Handler handlerType)
        {
            handlers.Add(handlerType);
        }

        public void  ExecuteAll()
        {
            foreach (var handler in handlers)
            {
                handler.HandleRequest(handler.request);
            }
        }

        public virtual void HandleRequest(int request) { }
    }
}
