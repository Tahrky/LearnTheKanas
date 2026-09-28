using ApprentissageKana.DAL.Models;
using ApprentissageKana.Utils;
using Microsoft.EntityFrameworkCore;

namespace ApprentissageKana.DAL
{
    public class KanaContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Symbole> Symboles { get; set; }
        public DbSet<Stats> Stats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.DefaultConnection);
        }
    }
}
