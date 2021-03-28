using FacetedBuilderPro.Models;

namespace FacetedBuilderPro.Builder
{
    //is facade for other builder , it allow access to sub builder
    //in order to provide access to child builder we initialize instance to each builder
    public class PersonBuilder
    {
        //reference 
        protected Person person = new Person();

        public PersonJobBuilder works => new PersonJobBuilder(person);
        
        public PersonAddressBuilder Address => new PersonAddressBuilder(person);

        //we provide static method that provide impolicit conversion from PersonBuilder to Person
        public static implicit operator Person(PersonBuilder pb) 
        {
            return pb.person;
        }
    }
}
