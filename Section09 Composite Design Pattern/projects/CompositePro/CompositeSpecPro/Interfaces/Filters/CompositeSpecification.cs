namespace CompositeSpecPro.Interfaces.Filters
{
    //CompositeSpecification make params Ispcification<T>[] items
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        protected readonly ISpecification<T>[] Items;

        public CompositeSpecification(params ISpecification<T>[] items) 
        {
            Items = items;
        }
    }
}
