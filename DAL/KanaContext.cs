using ApprentissageKana.DAL.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApprentissageKana.DAL
{
    public class KanaContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Components.Utils.Configuration.DefaultConnection);
        }
    }
}
