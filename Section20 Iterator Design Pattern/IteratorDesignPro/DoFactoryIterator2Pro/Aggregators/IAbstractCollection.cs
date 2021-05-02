using DoFactoryIterator2Pro.Iterators;

namespace DoFactoryIterator2Pro.Aggregators
{
    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
