using DoFactory2ChainOfResp.Models;

//we make field that refer to the same class that all sub classes inherit from it and using it to call abstract method as below
namespace DoFactory2ChainOfResp.Handlers
{
    abstract class Approver
    {
        protected Approver successor;

        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
