using ApprentissageKana.Class;

namespace ApprentissageKana.Services
{
    public class KanaToGuessService
    {
        /// <summary>
        /// Algorithme permettant de choisir le prochain caractère à deviner.
        /// Réinitialise les listes si elles sont vides.
        /// </summary>
        public void generateKanaToGuess(ref List<Kana> listHiraganaToGuess, ref List<Kana> listKatakanaToGuess, bool hiragana, 
            bool katakana, List<bool> categories, ref Kana toGuess, ref string fontName, List<Font> eligibleFonts)
        {
            Random rand = new Random();

            if (listHiraganaToGuess.Count == 0)
                listHiraganaToGuess = Kana.initialiseAllKana(categories).Where(x => !String.IsNullOrEmpty(x.unicodeHiragana)).ToList();

            // Il y a plus de Katakana que d’Hiragana
            if (listKatakanaToGuess.Count == 0)
                listKatakanaToGuess = Kana.initialiseAllKana(categories);

            if (hiragana && katakana)
            {
                KanaType resultEnum = (KanaType)rand.Next(2);

                if (resultEnum == KanaType.Hiragana)
                    updateGuess(ref listHiraganaToGuess, KanaType.Hiragana, ref toGuess, ref fontName, eligibleFonts);
                else if (resultEnum == KanaType.Katakana)
                    updateGuess(ref listKatakanaToGuess, KanaType.Katakana, ref toGuess, ref fontName, eligibleFonts);
            }
            else if (hiragana && !katakana)
                updateGuess(ref listHiraganaToGuess, KanaType.Hiragana, ref toGuess, ref fontName, eligibleFonts);
            else if (katakana && !hiragana)
                updateGuess(ref listKatakanaToGuess, KanaType.Katakana, ref toGuess, ref fontName, eligibleFonts);
        }

        /// <summary>
        /// Fonction qui définit le prochain caractère à deviner dans la liste.
        /// </summary>
        public void updateGuess(ref List<Kana> listKana, KanaType resultEnum, ref Kana toGuess, ref string fontName, List<Font> eligibleFonts)
        {
            if (listKana.Count <= 0)
                return;

            Random rand = new Random();
            toGuess = listKana.ElementAt(rand.Next(listKana.Count));
            Kana recopyToGuess = toGuess;
            listKana = listKana.Where(x => x.GetHashCode() != recopyToGuess.GetHashCode()).ToList();
            toGuess.kanaType = resultEnum;

            if (eligibleFonts.Count == 0)
                fontName = "NotoSansJP";
            else
                fontName = eligibleFonts.ElementAt(rand.Next(eligibleFonts.Count)).nom;
        }
    }
}
