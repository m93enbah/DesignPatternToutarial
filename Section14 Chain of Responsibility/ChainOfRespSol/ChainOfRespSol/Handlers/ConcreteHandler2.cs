using System;

namespace DoFactoryChainOfResp.Handlers
{
    class ConcreteHandler2 : Handler
    {
        public ConcreteHandler2(int request)
        {
            base.request = request;
        }

        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0} handled request {1}",
                  this.GetType().Name, request);
            }
        }
    }
}
