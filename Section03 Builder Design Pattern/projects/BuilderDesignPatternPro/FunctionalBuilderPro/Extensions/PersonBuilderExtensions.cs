using FunctionalBuilderPro.Builders;

namespace FunctionalBuilderPro.Extensions
{
    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorksAsA(this PersonBuilder builder, string position)
        {
            builder.Actions.Add(p =>
            {
                p.Position = position;
            });
            return builder;
        }
    }
}
