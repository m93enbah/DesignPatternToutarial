using FunctionalBuilderPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalBuilderPro.Builders
{
    public sealed class PersonBuilder
    {
        public readonly List<Action<Person>> Actions = new List<Action<Person>>();

        public PersonBuilder Called(string name)
        {
            Actions.Add(p => { p.Name = name; });
            return this;
        }

        public Person Build()
        {
            var p = new Person();
            Actions.ForEach(a => a(p));
            return p;
        }
    }
}
