namespace GenericValuePro
{
    //we inherit VectorOfInt with the Vector with pass int data type
    public class VectorOfInt<D> : Vector<VectorOfInt<D>, int, D>
      where D : IInteger, new()
    {
        public VectorOfInt()
        {
        }

        public VectorOfInt(params int[] values) : base(values)
        {
        }

        //we using operator to apply operation between two instances
        public static VectorOfInt<D> operator +
          (VectorOfInt<D> lhs, VectorOfInt<D> rhs)
        {
            var result = new VectorOfInt<D>();
            var dim = new D().Value;
            for (int i = 0; i < dim; i++)
            {
                result[i] = lhs[i] + rhs[i];
            }

            return result;
        }
    }
}
