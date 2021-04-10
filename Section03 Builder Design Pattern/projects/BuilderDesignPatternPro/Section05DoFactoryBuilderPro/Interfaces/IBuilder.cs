using Section05DoFactoryBuilderPro.Models;

namespace Section05DoFactoryBuilderPro.Interfaces
{
    public interface IBuilder
    {
        public  IBuilder BuildPartA();
        public IBuilder BuildPartB();
        public  Product GetResult();
    }
}
