namespace ApprentissageKana.Class
{
    public enum Difficulte
    {
        Facile = 0,
        Intermediaire = 1,
        Difficile = 2,
        Exotique = 3
    }

    public class Font
    {
        public string nom { get; set; } = string.Empty;
        public Difficulte difficulte { get; set; } = Difficulte.Facile;

        public Font(string _nom, Difficulte _difficulte = Difficulte.Facile)
        {
            nom = _nom;
            difficulte = _difficulte;
        }
    }
}
