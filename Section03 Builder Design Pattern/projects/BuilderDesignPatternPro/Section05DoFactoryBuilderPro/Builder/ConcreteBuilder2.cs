using Section05DoFactoryBuilderPro.Interfaces;
using Section05DoFactoryBuilderPro.Models;

namespace Section05DoFactoryBuilderPro.Builder
{
    public class ConcreteBuilder2 : IBuilder

    {
        private Product _product = new Product();

        public IBuilder BuildPartA()
        {
            _product.Add("PartX");
            return this;
        }

        public IBuilder BuildPartB()
        {
            _product.Add("PartY");
            return this;
        }

        public Product GetResult()
        {
            return _product;
        }
    }
}
