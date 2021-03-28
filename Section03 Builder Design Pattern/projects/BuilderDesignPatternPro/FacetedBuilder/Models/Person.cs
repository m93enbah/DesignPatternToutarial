namespace FacetedBuilderPro.Models
{
    public class Person
    {
        public string StreetAddress { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public int AnnualIncome { get; set; }

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress},{nameof(PostCode)}: {PostCode},{nameof(City)}: {City},{nameof(CompanyName)}: {CompanyName},{nameof(Position)}: {Position},{nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }
}
