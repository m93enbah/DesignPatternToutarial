using DoFactoryIteratorDesignPro.Iterators;
using System.Collections;

namespace DoFactoryIteratorDesignPro.Aggregators
{
    class ConcreteAggregate : Aggregate
    {
        private ArrayList _items = new ArrayList();

        //we create new instance of the CreateIterator and link between ConcreteAggregate and ConcreteIterator
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        // Gets item count
        public int Count
        {
            get { return _items.Count; }
        }

        //to set value and get value from list through indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}
