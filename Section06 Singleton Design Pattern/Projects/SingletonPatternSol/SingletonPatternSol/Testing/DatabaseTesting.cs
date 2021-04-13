using NUnit.Framework;
using SingletonPatternSol.Models;

namespace SingletonPatternSol.Testing
{
    /// <summary>
    /// IMPORTANT: be sure to turn off shadow copying for unit tests in R#!
    /// </summary>
    [TestFixture]
    public class SingletonTests
    {
        //to check if the singleton generate only 1 instance
        [Test]
        public void IsSingletonTest()
        {
            var db = SingletonDatabase.Instance;
            var db2 = SingletonDatabase.Instance;
            Assert.That(db, Is.SameAs(db2));
            Assert.That(SingletonDatabase.Count, Is.EqualTo(1));
        }

        //to read from SingeltonDatabase and apply TotalPopulation
        [Test]
        public void SingletonTotalPopulationTest()
        {
            // testing on a live database
            var rf = new SingletonRecordFinder();
            var names = new[] { "Seoul", "Mexico City" };
            int tp = rf.TotalPopulation(names);
            Assert.That(tp, Is.EqualTo(17500000 + 17400000));
        }

        //to read from Dummy Database and assign as parameter IDatabase 
        //to load the GetTotalPopuplation that implement on both 
        //DummyDatabase and SingletonDatabase
        [Test]
        public void DependantTotalPopulationTest()
        {
            var db = new DummyDatabase();
            var rf = new ConfigurableRecordFinder(db);
            Assert.That(
              rf.GetTotalPopulation(new[] { "alpha", "gamma" }),
              Is.EqualTo(4));
        }
    }
}
