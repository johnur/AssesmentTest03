using AssessmentTest03.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentTest03
{
    public class EfMethods
    {
        internal static void AddParty(PoliticalParty party)
        {
            var context = new PoliticalContext();
            context.PoliticalParties.Add(party);
            context.SaveChanges();
        }

        internal static string[] GetAllAbbreviatedNamesOrderedByFoundedDate()
        {
            var context = new PoliticalContext();
            return context.PoliticalParties.OrderBy(p => p.Founded).Select(c => c.AbbreviatedName).ToArray();

        }

        internal static void RecreateDatabase()
        {
            var context = new PoliticalContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        internal static void ClearDatabase()
        {
            var context = new PoliticalContext();
            context.RemoveRange(context.PoliticalParties);
            context.SaveChanges();
        }

    }
}
