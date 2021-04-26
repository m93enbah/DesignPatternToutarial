using DoFactory2ChainOfResp.Models;
using System;

namespace DoFactory2ChainOfResp.Handlers
{
    class Director : Approver
    {
        //on each child class it using the successor which is the Approver instance
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                  this.GetType().Name, purchase.Number);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }
    }
}
