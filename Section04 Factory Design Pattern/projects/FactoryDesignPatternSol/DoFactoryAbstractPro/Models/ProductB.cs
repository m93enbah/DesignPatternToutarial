using System;

namespace DoFactoryAbstractPro.Models
{
    public class ProductB : IBuilder
    {
        public void Interact(IBuilder a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }
}
