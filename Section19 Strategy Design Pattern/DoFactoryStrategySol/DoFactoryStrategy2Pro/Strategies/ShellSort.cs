using System;
using System.Collections.Generic;

namespace DoFactoryStrategy2Pro.Strategies
{
    class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("ShellSorted list ");
        }
    }
}
