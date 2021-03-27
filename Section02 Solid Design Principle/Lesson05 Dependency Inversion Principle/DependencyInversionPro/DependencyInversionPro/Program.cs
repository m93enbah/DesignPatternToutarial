using DependencyInversionPro.Manager;
using DependencyInversionPro.Models;
using DependencyInversionPro.Repositories;
using static System.Console;
namespace DotNetDesignPatternDemos.SOLID.DependencyInversionPrinciple
{
    // hl modules should not depend on low-level; both should depend on abstractions
    // abstractions should not depend on details; details should depend on abstractions
    public class Program 
    {
        static void Main(string[] args)
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Matt" };

            // low-level module
            var relationships = new RelationshipsRepo();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new ResearchManager(relationships);
            ReadLine();
        }
    }
}
