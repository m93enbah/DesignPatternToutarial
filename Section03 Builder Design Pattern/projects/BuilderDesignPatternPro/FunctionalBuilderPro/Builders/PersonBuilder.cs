using FunctionalBuilderPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalBuilderPro.Builders
{
    public sealed class PersonBuilder
    {
        public readonly List<Action<Person>> Actions = new List<Action<Person>>();

        //actions here is delegate that have input of type Person and it will set property Name value
        public PersonBuilder Called(string name)
        {
            Actions.Add(p => { p.Name = name; });
            return this;
        }

        //actions here is delegate that will set the property Area to the Person instance
        public PersonBuilder SetArea(string area)
        {
            Actions.Add(p => { p.Area = area; });
            return this;
        }

        //this method call actions that will apply the anonmous method and it will set 
        //all the properities for the Person class
        public Person Build()
        {
            var p = new Person();
            Actions.ForEach(a => a(p));
            return p;
        }
    }
}
