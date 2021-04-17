namespace CompositeSpecPro.Interfaces
{
    //the abstract class is the base class for all filters
    public abstract class ISpecification<T>
    {
       public abstract  bool IsSatisfied(T obj);
    }
}
