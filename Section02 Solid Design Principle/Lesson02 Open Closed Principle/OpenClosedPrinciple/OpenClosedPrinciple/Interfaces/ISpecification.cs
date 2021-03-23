namespace OpenClosedPrinciple.Interfaces
{
    //this generic interface pass any class into the action IsSatisfied
    public interface ISpecification<T>
    {
        bool IsSatisfied(T obj);
    }
}
