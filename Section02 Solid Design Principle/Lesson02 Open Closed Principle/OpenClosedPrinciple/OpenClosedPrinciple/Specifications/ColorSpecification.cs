using OpenClosedPrinciple.Interfaces;
using OpenClosedPrinciple.Models;

namespace OpenClosedPrinciple.Specifications
{
    //this class pass Product instance and make check if color matched 
    public class ColorSpecification : ISpecification<Product>
    {
        public Color _color { get; set; }
        public ColorSpecification(Color color)
        {
            this._color = color;
        }
        public bool IsSatisfied(Product obj)
        {
            return obj.Color == _color;
        }
    }

}
