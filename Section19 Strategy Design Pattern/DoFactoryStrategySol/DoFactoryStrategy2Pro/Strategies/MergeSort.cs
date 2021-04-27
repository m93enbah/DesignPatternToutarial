using System;
using System.Collections.Generic;

namespace DoFactoryStrategy2Pro.Strategies
{
    class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("MergeSorted list ");
        }
    }
}
