using DoFactoryChainOfResp.Handlers;
using System;
namespace DoFactoryChainOfResp
{

    //chain of responsiblity : Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
    //Chain the receiving objects and pass the request along the chain until an object handles it.
    
    //this way is prefered becouse you combine the register and calling them on the same line as below
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility
            var handler = new Handler();
            handler.Register(new ConcreteHandler1(1));
            handler.Register(new ConcreteHandler2(11));
            handler.Register(new ConcreteHandler3(21));
            handler.ExecuteAll();

            Console.ReadKey();
        }
    }
}
