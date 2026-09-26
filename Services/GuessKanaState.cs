using ApprentissageKana.Class;
using ApprentissageKana.Utils;

namespace ApprentissageKana.Services
{
    public sealed class GuessKanaState
    {
        private readonly KanaToGuessService _kanaToGuessService;

        private List<Kana> _listHiraganaToGuess = new ();
        private List<Kana> _listKatakanaToGuess = new ();
        private Kana _toGuess = new ();

        public List<Kana> ListHiraganaToGuess => _listHiraganaToGuess;
        public List<Kana> ListKatakanaToGuess => _listKatakanaToGuess;
        public List<Tuple<string, string>> Historique { get; } = new ();

        // Symbole à deviner
        public Kana ToGuess => _toGuess;
        // Proposition du joueur
        public string KanaToGuess { get; set; } = string.Empty;

        public bool Hiragana { get; private set; } = true;
        public bool Katakana { get; private set; } = true;

        public List<Difficulte> FontsDifficulty { get; } = new ()
        {
            Difficulte.Facile,
            Difficulte.Intermediaire
        };
        public string FontName { get; private set; } = "NotoSansJP";
        public List<bool> Categories { get; } = new() { true, false, false, false };
        public List<Font> EligibleFonts { get; private set; } = new();

        public int CompteurDePoint { get; private set; }
        public int CompteurTotal { get; private set; }

        public event Action? OnChange;

        public GuessKanaState(KanaToGuessService kanaToGuessService)
        {
            _kanaToGuessService = kanaToGuessService;
            RefreshKanaListsInternal();
            RefreshEligibleFontsInternal();
            GenerateKana();
        }

        public void GenerateKana()
        {
            if (!Hiragana && !Katakana) 
                return;

            if (EligibleFonts.Count == 0) 
                return;

            _kanaToGuessService.generateKanaToGuess(ref _listHiraganaToGuess, ref _listKatakanaToGuess,
                Hiragana, Katakana, Categories, ref _toGuess, ref _fontName, EligibleFonts);

            NotifyStateChanged();
        }

        // Champ privé nécessaire pour le "ref" ci-dessus
        private string _fontName = "NotoSansJP";

        public void RefreshKanaLists()
        {
            RefreshKanaListsInternal();
            NotifyStateChanged();
        }

        public void RefreshEligibleFonts()
        {
            RefreshEligibleFontsInternal();
            NotifyStateChanged();
        }

        public void ToggleCategorie(int position)
        {
            if (position < 0 || position >= Categories.Count) return;

            Categories[position] = !Categories[position];
            RefreshKanaListsInternal();
            GenerateKana();
        }

        public void ToggleFontDifficulty(Difficulte diff)
        {
            if (!FontsDifficulty.Remove(diff))
                FontsDifficulty.Add(diff);

            RefreshEligibleFontsInternal();
            GenerateKana();
        }

        public void ToggleHiragana()
        {
            Hiragana = !Hiragana;
            GenerateKana();
        }

        public void ToggleKatakana()
        {
            Katakana = !Katakana;
            GenerateKana();
        }

        public void Submit()
        {
            if (!string.IsNullOrEmpty(KanaToGuess))
            {
                CompteurTotal++;
                string statusToDisplay;

                bool isCorrect = _toGuess.nom.ToLower().Equals(KanaToGuess.ToLower())
                                    || (!string.IsNullOrEmpty(_toGuess.nomAlternatif)
                                         && _toGuess.nomAlternatif.ToLower()
                                         .Equals(KanaToGuess.ToLower()));

                if (isCorrect)
                {
                    statusToDisplay = "alert alert-success";
                    CompteurDePoint++;
                }
                else
                    statusToDisplay = "alert alert-danger";

                Historique.Add(new Tuple<string, string>( "Réponse : " + _toGuess.texteAAfficher 
                    + " (" + _toGuess.nom + ") - Proposition : " + KanaToGuess, statusToDisplay));

                KanaToGuess = string.Empty;
            }

            GenerateKana();
        }

        public void Skip()
        {
            KanaToGuess = string.Empty;
            Historique.Add(new Tuple<string, string>( "Réponse : " + _toGuess.texteAAfficher 
                + " (" + _toGuess.nom + ")", "alert alert-secondary"));

            GenerateKana();
        }

        private void RefreshKanaListsInternal()
        {
            List<Kana> allKana = Kana.initialiseAllKana(Categories);

            _listHiraganaToGuess = allKana
                .Where(k => !string.IsNullOrEmpty(k.unicodeHiragana))
                .ToList();

            _listKatakanaToGuess = allKana;
        }

        private void RefreshEligibleFontsInternal()
        {
            EligibleFonts = Globales.AllFonts
                .Where(f => FontsDifficulty.Contains(f.difficulte))
                .ToList();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}