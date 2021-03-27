using DependencyInversionPro.Enums;
using DependencyInversionPro.Interfaces;
using DependencyInversionPro.Models;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInversionPro.Repositories
{
    public class RelationshipsRepo : IRelationshipBrowserRepo // low-level
    {
        private List<(Person, Relationship, Person)> relations
          = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }

        public List<(Person, Relationship, Person)> Relations { 
            get 
            {
                return relations; 
            }
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations
              .Where(x => x.Item1.Name == name
                          && x.Item2 == Relationship.Parent).Select(r => r.Item3);
        }
    }
}
