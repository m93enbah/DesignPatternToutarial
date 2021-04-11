using DoFactoryAbstractPro.Interfaces;
using DoFactoryAbstractPro.Models;

namespace DoFactoryAbstractPro.Factory
{
    public class ProductAFactory : IAbstractFactory
    {
        public IBuilder CreateProduct()
        {
            return new ProductA();
        }
    }
}
