namespace GenericValuePro
{
    //we inherit VectorOfFloat with the Vector with pass float data type
    public class VectorOfFloat<TSelf, D>
     : Vector<TSelf, float, D>
     where D : IInteger, new()
     where TSelf : Vector<TSelf, float, D>, new()
    {
    }
}
