using System;

namespace ICloneablePro.Models
{
    public class Person : ICloneable
    {
        public string[] Names { get; set; }

        public Address Address { get; set; }

        public Person(string[] names, Address address) 
        {
            if (names == null) 
            {
                throw new ArgumentNullException(paramName: nameof(names)); ;
            }
            if (address == null) 
            {
                throw new ArgumentNullException(paramName: nameof(address)); ;
            }
            Names = names;
            Address = address;
        }

        public override string ToString()
        {
            return $"{nameof(Names)} : {string.Join(",",Names)} , {nameof(Address)} : {Address}";
        }
        //we inherit ICloneable in Person and Address class and it will apply shallow copy
        public object Clone()
        {
            return new Person(Names, (Address)Address.Clone());
        }
    }
}
