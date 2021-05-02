using DoFactoryIterator2Pro.Aggregators;

namespace DoFactoryIterator2Pro.Iterators
{
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}