using DoFactoryIteratorDesignPro.Iterators;

namespace DoFactoryIteratorDesignPro.Aggregators
{
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
