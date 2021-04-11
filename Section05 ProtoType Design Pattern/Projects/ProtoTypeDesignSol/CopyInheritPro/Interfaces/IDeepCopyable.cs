namespace CopyInheritPro.Interfaces
{
    //in order to apply Depp copy we apply default implementation interface DeepCopy()
    //with call the abstract CopyTo that call the extension method DeepCopyExtensions > DeepCopy
    public interface IDeepCopyable<T> where T : new()
    {
        void CopyTo(T target);

        //the default interface implemntation will return new Deep Copy instance
        public T DeepCopy()
        {
            T t = new T();
            CopyTo(t);
            return t;
        }
    }
}
