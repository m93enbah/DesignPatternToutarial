using DoFactory2ChainOfResp.Handlers;
using DoFactory2ChainOfResp.Models;
using System;

namespace DoFactory2ChainOfResp
{
    //this way is not prefered becouse you are not register these sub classes and call them all on the same line 
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();
            //we assign the instance of the child into the partent
            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests which make process to the same instance multiple stages
            Purchase p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);

            // Wait for user
            Console.ReadKey();
        }
    }
}
