using Section05DoFactoryBuilderPro.Models;

namespace Section05DoFactoryBuilderPro.Builder
{
    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }
}
