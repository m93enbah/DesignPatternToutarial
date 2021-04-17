using CompositeSpecPro.Enums;
using CompositeSpecPro.Models;

namespace CompositeSpecPro.Interfaces.Filters
{
    public class ColorSpecification : ISpecification<Product>
    {
        public Color _color { get; set; }
        public ColorSpecification(Color color) { this._color = color; }

        public override bool IsSatisfied(Product obj)
        {
            return obj.Color == _color;
        }
    }

}
