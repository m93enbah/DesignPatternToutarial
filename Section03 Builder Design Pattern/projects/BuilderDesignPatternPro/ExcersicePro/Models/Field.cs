namespace ExcersicePro.Models
{
    public class Field
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"public {Type} {Name}";
        }
    }
}
