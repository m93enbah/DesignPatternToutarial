using FunctionalBuilderPro.Builders;

namespace FunctionalBuilderPro.Extensions
{
    public static class PersonBuilderExtensions
    {
        //this extension method contain add the actions which refer to the person instance 
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
