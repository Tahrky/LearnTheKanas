using ApprentissageKana.Class;
using ApprentissageKana.Utils;
using ApprentissageKana.Services;

namespace ApprentissageKana.States
{
    public sealed class GuessKanaState
    {
        private readonly KanaToGuessService _kanaToGuessService;
        private List<Kana> _listHiraganaToGuess = new(), _listKatakanaToGuess = new ();
        private Kana _toGuess = new ();
        private string _fontName  = "NotoSansJP";
        public List<Tuple<string, string>> Historique { get; set; } = new ();
        // Symbole à deviner
        public Kana ToGuess => _toGuess;
        // Proposition du joueur
        public string KanaToGuess = string.Empty;
        public string FontName => _fontName;
        public bool Hiragana = true, Katakana = true;
        public List<Difficulte> FontsDifficulty { get; } = new () { Difficulte.Facile, Difficulte.Intermediaire };
        public List<bool> Categories { get; } = new() { true, false, false, false };
        public List<Font> EligibleFonts { get; private set; } = new();
        public int CompteurDePoint, CompteurTotal;
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
            if ((!Hiragana && !Katakana) || EligibleFonts.Count == 0) 
                return;

            _kanaToGuessService.generateKanaToGuess(ref _listHiraganaToGuess, ref _listKatakanaToGuess,
                Hiragana, Katakana, Categories, ref _toGuess, ref _fontName, EligibleFonts);

            NotifyStateChanged();
        }
        
        public void ToggleCategorie(int position)
        {
            if (position < 0 || position >= Categories.Count) 
                return;

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

        public void ToggleKana(bool kana)
        {
            if (kana) 
                Hiragana = !Hiragana; 
            else 
                Katakana = !Katakana;

            GenerateKana();
        }

        public void Submit()
        {
            if (!string.IsNullOrEmpty(KanaToGuess))
            {
                CompteurTotal++;
                string statusToDisplay = "alert alert-success";
                bool isCorrect = _toGuess.nom.ToLower().Equals(KanaToGuess.ToLower())
                                || (!string.IsNullOrEmpty(_toGuess.nomAlternatif)
                                    && _toGuess.nomAlternatif.ToLower().Equals(KanaToGuess.ToLower()));

                if (isCorrect)
                    CompteurDePoint++;
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
            // Il existe certains symboles en Katakana qui n’existe pas en Hiragana, c’est pour ça qu’il faut trier.
            _listHiraganaToGuess = allKana.Where(k => !string.IsNullOrEmpty(k.unicodeHiragana)).ToList();
            _listKatakanaToGuess = allKana;
        }

        public void ResetHistorique()
        {
            Historique = new List<Tuple<string, string>>();
        }

        private void RefreshEligibleFontsInternal() => EligibleFonts = Globales.AllFonts.Where(f => FontsDifficulty.Contains(f.difficulte)).ToList();
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}