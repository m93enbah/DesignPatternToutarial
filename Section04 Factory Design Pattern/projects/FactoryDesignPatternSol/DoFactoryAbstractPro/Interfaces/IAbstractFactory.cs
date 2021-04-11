using DoFactoryAbstractPro.Models;

namespace DoFactoryAbstractPro.Interfaces
{
    public interface IAbstractFactory
    {
        public IBuilder CreateProduct();
    }
}
