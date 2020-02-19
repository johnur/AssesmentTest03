using Microsoft.EntityFrameworkCore;

namespace AssessmentTest03.Domain
{
    public class PoliticalContext : DbContext
    {
        public DbSet<PoliticalParty> PoliticalParties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = PoliticalParties; Trusted_Connection = True; ");
        }
    }

}
