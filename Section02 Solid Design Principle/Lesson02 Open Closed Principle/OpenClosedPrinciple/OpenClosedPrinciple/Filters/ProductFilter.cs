using OpenClosedPrinciple.Models;
using System.Collections.Generic;

namespace OpenClosedPrinciple.Filters
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var prod in products)
                if (prod.Size == size)
                    yield return prod;
        }
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var prod in products)
                if (prod.Color == color)
                    yield return prod;
        }

        public IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products, Color color, Size size)
        {
            foreach (var prod in products)
                if (prod.Color == color && prod.Size == prod.Size)
                    yield return prod;
        }
    }

}
