using ExplicitDeepCopyPro.Interfaces;
using System;

namespace ExplicitDeepCopyPro.Models
{
    public class Address : IProtoType<Address>
    {
        public string StreetAddress, City, Country;

        public Address(string streetAddress, string city, string country)
        {
            StreetAddress = streetAddress ?? throw new ArgumentNullException(paramName: nameof(streetAddress));
            City = city ?? throw new ArgumentNullException(paramName: nameof(city));
            Country = country ?? throw new ArgumentNullException(paramName: nameof(country));
        }

        //to apply deep copy we pass the instnace and assign value with apply initialize of sub class
        public Address(Address other)
        {
            StreetAddress = other.StreetAddress;
            City = other.City;
            Country = other.Country;
        }

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(City)}: {City}, {nameof(Country)}: {Country}";
        }

        public Address DeepCopy()
        {
            return new Address(StreetAddress, City, Country);
        }
    }
}
