

using CompositeSpecPro.Enums;
using CompositeSpecPro.Models;
using System.Collections.Generic;

namespace CompositeSpecPro.Filters
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var prod in products)
                if (prod.Size.Equals(size))
                    yield return prod;
        }
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var prod in products)
                if (prod.Color.Equals(color))
                    yield return prod;
        }

        public IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products, Color color, Size size)
        {
            foreach (var prod in products)
                if (prod.Color.Equals(color) && prod.Size.Equals(prod.Size))
                    yield return prod;
        }
    }
}
