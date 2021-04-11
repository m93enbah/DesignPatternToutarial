using DoFactoryAbstractPro.Interfaces;
using DoFactoryAbstractPro.Models;

namespace DoFactoryAbstractPro.Factory
{
    public class ProductBFactory : IAbstractFactory
    {
        public IBuilder CreateProduct()
        {
            return new ProductB();
        }
    }
}
