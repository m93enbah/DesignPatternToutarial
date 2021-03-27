using DependencyInversionPro.Models;
using System.Collections.Generic;

namespace DependencyInversionPro.Interfaces
{
    public interface IRelationshipBrowserRepo
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}
