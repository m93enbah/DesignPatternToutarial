using CompositeSpecPro.Models;
using System.Collections.Generic;

namespace CompositeSpecPro.Interfaces.Filters
{
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
