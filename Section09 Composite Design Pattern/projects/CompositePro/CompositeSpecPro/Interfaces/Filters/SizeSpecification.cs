using CompositeSpecPro.Enums;
using CompositeSpecPro.Models;

namespace CompositeSpecPro.Interfaces.Filters
{
    public class SizeSpecification : ISpecification<Product>
    {
        public Size _size { get; set; }
        public SizeSpecification(Size size) { this._size = size; }

        public override bool IsSatisfied(Product obj)
        {
            return obj.Size.Equals(_size);
        }
    }
}
