using Section05DoFactoryBuilderPro.Models;

namespace Section05DoFactoryBuilderPro.Builder
{
    public class ConcreteBuilder1 : Builder
    {
        private Product _product = new Product();

        public override ConcreteBuilder1 BuildPartA()
        {
            _product.Add("PartA");
            return this;    
        }

        public override ConcreteBuilder1 BuildPartB()
        {
            _product.Add("PartB");
            return this;
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
