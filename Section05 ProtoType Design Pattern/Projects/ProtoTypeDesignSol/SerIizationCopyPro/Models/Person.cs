using SerIizationCopyPro.Extensions;
using System;

namespace SerIizationCopyPro.Models
{
    [Serializable]
    public class Person
    {
        public string[] Names;
        public Address Address;

        public Person() { }

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(",", Names)}, {nameof(Address)}: {Address}";
        }
    }
}
