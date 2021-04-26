using DoFactory2ChainOfResp.Models;
using System;

namespace DoFactory2ChainOfResp.Handlers
{
    class President : Approver
    {
        //on each child class it using the successor which is the Approver instance
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                  this.GetType().Name, purchase.Number);
            }
            else

            {
                Console.WriteLine(
                  "Request# {0} requires an executive meeting!",
                  purchase.Number);
            }
        }
    }
}
