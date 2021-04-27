using System.Collections.Generic;

namespace DoFactoryStrategy2Pro.Strategies
{
    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
