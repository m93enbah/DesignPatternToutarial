using CopyInheritPro.Extensions;
using CopyInheritPro.Interfaces;

namespace CopyInheritPro.Models
{
    //we implement the interface IDeepCopyable
    public class Person : IDeepCopyable<Person>
    {
        public string[] Names;
        public Address Address;

        public Person(){}

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(",", Names)}, {nameof(Address)}: {Address}";
        }

        public virtual void CopyTo(Person target)
        {
            //call the ICloneable interface
            target.Names = (string[])Names.Clone();
            //it will call the Address DeepCopy() of Address
            target.Address = Address.DeepCopy();
        }
    }
}
