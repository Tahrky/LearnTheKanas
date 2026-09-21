using System.ComponentModel.DataAnnotations;

namespace ApprentissageKana.DAL.Models
{
    public class Stats
    {
        [Key]
        public int id { get; set; }
        public ulong totalGuess { get; set; }
        public ulong sucessfulGuess { get; set; }
        public ulong passGuess { get; set; }

        // Jointure vers d’autres tables
        public Users user { get; set; }
        public Symbole symbole { get; set; }
    }
}
