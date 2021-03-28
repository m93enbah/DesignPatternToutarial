using FacetedBuilderPro.Models;

namespace FacetedBuilderPro.Builder
{
    //on the child class it inherit from the base class and person
    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person) 
        {
            this.person = person;
        }

        //it will return the class instance to apply Builder pattern
        public PersonAddressBuilder At(string streetAddress)
        {
            person.StreetAddress = streetAddress;
            return this;
        }

        //it will return the class instance to apply Builder pattern
        public PersonAddressBuilder WithPostCode(string postCode)
        {
            person.PostCode = postCode;
            return this;
        }

        //it will return the class instance to apply Builder pattern
        public PersonAddressBuilder In(string city)
        {
            person.City = city;
            return this;
        }
    }
}
