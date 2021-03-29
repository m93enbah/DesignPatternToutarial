using Section05DoFactoryBuilderPro.Models;

namespace Section05DoFactoryBuilderPro.Builder
{
    public class ConcreteBuilder2 : Builder

    {
        private Product _product = new Product();

        public override ConcreteBuilder2 BuildPartA()
        {
            _product.Add("PartX");
            return this;
        }

        public override ConcreteBuilder2 BuildPartB()
        {
            _product.Add("PartY");
            return this;
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
