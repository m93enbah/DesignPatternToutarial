using DoFactoryIterator2Pro.Iterators;
using System.Collections;

namespace DoFactoryIterator2Pro.Aggregators
{
    class Collection : IAbstractCollection
    {
        private ArrayList _items = new ArrayList();

        //to create iterator based 
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        // Gets item count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
