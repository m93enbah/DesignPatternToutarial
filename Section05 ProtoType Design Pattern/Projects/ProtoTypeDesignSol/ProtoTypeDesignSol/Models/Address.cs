using System;

namespace ICloneablePro.Models
{
    public class Address : ICloneable
    {
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }


        public Address(string streetName,int houseNumber) 
        {
            if (streetName == null)
            {
                throw new ArgumentNullException(paramName: nameof(streetName)); ;
            }
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)} : {StreetName} , {nameof(HouseNumber)} : {HouseNumber}";
        }
        //we inherit ICloneable in Person and Address class and it will apply shallow copy
        public object Clone()
        {
            return new Address(StreetName, HouseNumber);
        }
    }
}
