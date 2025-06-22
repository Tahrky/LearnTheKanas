using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApprentissageKana.DAL
{
    public class KanaContext : DbContext
    {
        public DbSet<ApprentissageKana.Models.Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-EJF1JS3V;Initial Catalog=LearnTheKana;Integrated Security=SSPI;TrustServerCertificate=True");
        }
    }
}
