using Section05DoFactoryBuilderPro.Models;

namespace Section05DoFactoryBuilderPro.Builder
{
    public abstract class Builder
    {
        public abstract Builder BuildPartA();
        public abstract Builder BuildPartB();
        public abstract Product GetResult();
    }
}
