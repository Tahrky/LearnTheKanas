using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ApprentissageKana.Class;

namespace ApprentissageKana.DAL.Models
{
    public class Symbole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string caractereUnicode { get; set; }
        [Required]
        public string nom { get; set; }
        public string nomAlternatif { get; set; }
        [Required]
        public Categorie categorie { get; set; }
        public Nullable<KanaType> kanaType { get; set; }

        // Jointure vers d’autres tables
        public Traduction aide { get; set; }

        public Stats stats { get; set; }

        public Symbole ()
        {
            categorie = Categorie.Kanji;
            kanaType = null;
        }
    }
}
