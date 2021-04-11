using System;

namespace SerIizationCopyPro.Models
{
    [Serializable]
    public class Address 
    {
        public string StreetName;
        public int HouseNumber;
        public Address(string streetName, int houseNumber)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public Address() { }

        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
        }
    }

}
