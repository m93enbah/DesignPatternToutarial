using System.Collections.Generic;

namespace CompositeSpecPro.Interfaces
{
    //this interface takes items and Ispecification as parmaeters
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> sepc);
    }
}
