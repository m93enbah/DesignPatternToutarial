using DependencyInversionPro.Interfaces;
using DependencyInversionPro.Repositories;
using static System.Console;

namespace DependencyInversionPro.Manager
{
    public class ResearchManager
    {
        //public ResearchManager(RelationshipsRepo relationships)
        //{
        //    // high-level: find all of john's children
        //    //var relations = relationships.Relations;
        //    //foreach (var r in relations
        //    //  .Where(x => x.Item1.Name == "John"
        //    //              && x.Item2 == Relationship.Parent))
        //    //{
        //    //  WriteLine($"John has a child called {r.Item3.Name}");
        //    //}
        //}

        public ResearchManager(IRelationshipBrowserRepo browser)
        {
            foreach (var p in browser.FindAllChildrenOf("John"))
            {
                WriteLine($"John has a child called {p.Name}");
            }
        }
    }
}
