using System;

namespace DoFactoryChainOfResp.Handlers
{
    class ConcreteHandler3 : Handler
    {
        public ConcreteHandler3(int request)
        {
            base.request = request;
        }

        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0} handled request {1}",
                  this.GetType().Name, request);
            }
        }
    }
}
