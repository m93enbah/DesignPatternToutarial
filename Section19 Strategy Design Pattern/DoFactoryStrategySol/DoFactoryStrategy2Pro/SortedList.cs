using DoFactoryStrategy2Pro.Strategies;
using System;
using System.Collections.Generic;

namespace DoFactoryStrategy2Pro
{
    //in this class we apply SortedList which provide the functionality of attach strategy class and call it
    class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this._sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortstrategy.Sort(_list);
            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
