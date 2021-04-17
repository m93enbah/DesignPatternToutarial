using System;
using System.Linq;

namespace CompositeSpecPro.Interfaces.Filters
{
    //combinator inherit from CompositeSpecification
    //so we can pass as we want of specification filters as below
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        public AndSpecification(params ISpecification<T>[] items) :base(items)
        {
        }

        public override bool IsSatisfied(T t)
        {
            //Any => Or Specification
            return Items.All(i => i.IsSatisfied(t));
        }
    }
}
