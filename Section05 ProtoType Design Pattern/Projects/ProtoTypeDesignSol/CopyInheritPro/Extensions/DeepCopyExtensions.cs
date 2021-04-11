using CopyInheritPro.Interfaces;
using CopyInheritPro.Models;

namespace CopyInheritPro.Extensions
{
    public static class DeepCopyExtensions
    {
        //we call DeepCopy inside the overloaded CopyTo > Person class
        //this is used to DeepCopy Child > Address
        public static T DeepCopy<T>(this IDeepCopyable<T> item)
          where T : new()
        {
            return item.DeepCopy();
        }

        //this extension method call IDeepCopyable > DeepCopy() > CopyTo abstract
        //this is used to DeepCopy Parent > Person
        public static T DeepCopy<T>(this T person)
          where T : Person, new()
        {
            return ((IDeepCopyable<T>)person).DeepCopy();
        }
    }
}
