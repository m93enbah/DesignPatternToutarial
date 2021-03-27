namespace FluentBuilderPro.Builder
{
    //layer 01
    //This class inherit from PersonBuilder with pass T which is the PersonInfoBuilder<T>
    public class PersonInfoBuilder<T> : PersonBuilder where T : PersonInfoBuilder<T>
    {
        public T Called(string name)
        {
            person.Name = name;
            return (T)this;
        }
    }
}
