using FluentBuilderPro.Models;

namespace FluentBuilderPro.Builder
{
    //base class
    public abstract class PersonBuilder
    {
        protected Person person = new Person();

        public Person Build()
        {
            return person;
        }
    }
}
