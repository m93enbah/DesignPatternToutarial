using System;

namespace FluentBuilderPro.Builder
{
    //layer 03
    //This class inherit from PersonJobBuilder<PersonBirthDateBuilder<T>>
    //with pass T which is the PersonBirthDateBuilder<T>
    public class PersonBirthDateBuilder<T> : PersonJobBuilder<PersonBirthDateBuilder<T>>
     where T : PersonBirthDateBuilder<T>
    {
        public T Born(DateTime dateOfBirth)
        {
            person.DateOfBirth = dateOfBirth;
            return (T)this;
        }
    }
}
