using GamesStore.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GamesStore.DAL
{
    public class GamesStoreContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Developer> Developers { get; set; }

        public GamesStoreContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GamesStoreDb;Trusted_Connection=True;"); 
        }
    }
}
