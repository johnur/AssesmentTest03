using AssessmentTest03.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AssessmentTest03
{
    [TestClass]
    public class Level1EfTests
    {
        [TestMethod]
        public void add_parties_and_make_queries()
        {
            EfMethods.RecreateDatabase(); // To student: comment this line when the database is created
            EfMethods.ClearDatabase();

            var lib = new PoliticalParty
            {
                Name = "Liberalerna",
                AbbreviatedName = "L",
                Founded = new DateTime(1934, 8, 5),
                Members = 15390,
            };

            var miljo = new PoliticalParty
            {
                Name = "Miljöpartiet det gröna",
                AbbreviatedName = "MP",
                Founded = new DateTime(1981, 9, 20),
                Members = 10719,
            };

            var soc = new PoliticalParty
            {
                Name = "Sveriges socialdemokratiska arbetareparti",
                AbbreviatedName = "S",
                Founded = new DateTime(1889, 4, 23),
                Members = 89010,
            };

            EfMethods.AddParty(miljo);
            EfMethods.AddParty(lib);
            EfMethods.AddParty(soc);

            string[] result = EfMethods.GetAllAbbreviatedNamesOrderedByFoundedDate();

            string[] expected = new[] { "S", "L", "MP" };

            CollectionAssert.AreEqual(expected, result);

        }

    }
}
