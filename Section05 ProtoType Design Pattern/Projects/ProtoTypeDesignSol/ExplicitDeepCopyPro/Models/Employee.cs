using ExplicitDeepCopyPro.Interfaces;
using System;

namespace ExplicitDeepCopyPro.Models
{
    public class Employee : IProtoType<Employee>
    {
        public string Name;
        public Address Address;

        public Employee(string name, Address address)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Address = address ?? throw new ArgumentNullException(paramName: nameof(address));
        }


        //to apply deep copy we pass the instnace and assign value with apply initialize of sub class
        public Employee(Employee other)
        {
            Name = other.Name;
            Address = new Address(other.Address);
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Address)}: {Address}";
        }

        public Employee DeepCopy()
        {
            return new Employee(Name, Address.DeepCopy());
        }
    }
}
