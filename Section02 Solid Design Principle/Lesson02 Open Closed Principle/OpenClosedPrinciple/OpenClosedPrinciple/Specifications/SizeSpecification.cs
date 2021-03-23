using OpenClosedPrinciple.Interfaces;
using OpenClosedPrinciple.Models;

namespace OpenClosedPrinciple.Specifications
{
    //this class pass Product instance and make check if size matched
    public class SizeSpecification : ISpecification<Product>
    {
        public Size _size { get; set; }
        public SizeSpecification(Size size)
        {
            _size = size;
        }
        public bool IsSatisfied(Product obj)
        {
            return obj.Size == _size;
        }
    }

}
