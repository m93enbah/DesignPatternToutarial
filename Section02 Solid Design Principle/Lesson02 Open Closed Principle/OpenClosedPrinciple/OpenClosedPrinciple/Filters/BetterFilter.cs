using OpenClosedPrinciple.Interfaces;
using OpenClosedPrinciple.Models;
using System.Collections.Generic;

namespace OpenClosedPrinciple.Filters
{
    //we see that each filter class inherit from the IFilter interface that pass the ISpecification as parameter 
    //and use IsSatisfied
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)

                if (spec.IsSatisfied(item))
                    yield return item;
        }
    }
}
