using FacetedBuilderPro.Models;

namespace FacetedBuilderPro.Builder
{
    //on the child class it inherit from the base class and person
    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.person = person;
        }
   
        //it will return the class instance to apply Builder pattern
        public PersonJobBuilder At(string companyName) 
        {
            person.CompanyName = companyName;
            return this;
        }

        //it will return the class instance to apply Builder pattern
        public PersonJobBuilder AsA(string position) 
        {
            person.Position = position;
            return this;
        }

        //it will return the class instance to apply Builder pattern
        public PersonJobBuilder Earning(int amount) 
        {
            person.AnnualIncome = amount;
            return this;
        }
    }
}
