namespace FluentBuilderPro.Builder
{
    //layer 02
    //This class inherit from PersonInfoBuilder<PersonJobBuilder<T>>
    //with pass T which is the PersonJobBuilder<T>
    public class PersonJobBuilder<T>: PersonInfoBuilder<PersonJobBuilder<T>>
     where T : PersonJobBuilder<T>
    {
        public T WorksAsA(string position)
        {
            person.Position = position;
            return (T)this;
        }
    }
}
