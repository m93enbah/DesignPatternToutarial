using System;

namespace DoFactoryChainOfResp.Handlers
{
    class ConcreteHandler1 : Handler
    {

        public ConcreteHandler1(int request) 
        {
            base.request = request;
        }

        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine("{0} handled request {1}",
                  this.GetType().Name, request);
            }
        }
    }
}
