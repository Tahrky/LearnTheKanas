using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApprentissageKana.DAL.Models
{
    public enum Langue
    {
        French = 0,
        English = 1,
        Italian = 2,
        Spanish = 3,
    }
    public class Traduction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string caractereUnicode { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Langue langue { get; set; }
        public string traduction { get; set; }
    }
}
