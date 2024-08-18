namespace ApprentissageKana.Components.Composants
{
    public enum TexteATraduire
    {
        Language = 0,
        LearnKana = 1,
        GuessKana = 2,
        Success = 3,
        Error = 4,
        PreviousKanaWas = 5,
        Font = 6,
        EasyDifficulty = 7,
        MidDifficulty = 8,
        HardDifficulty = 9,
        SpecialDifficulty = 10,
        RecapTab = 11,
        FontName = 12,
        FoundKana = 13,
        Tries = 14,
        Help = 15,
        Skip = 16,
        Validation = 17,
    }

    public class Traduction
    {
        public TexteATraduire reference { get; set; }
        public String traduction { get; set; }

    }

    public static class TraductionManager
    {

    }
}
