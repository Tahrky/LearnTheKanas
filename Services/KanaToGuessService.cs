using ApprentissageKana.Class;
using Microsoft.AspNetCore.Components;

namespace ApprentissageKana.Services
{
    public class KanaToGuessService
    {
        /// <summary>
        /// Algorithme permettant de choisir le prochain caractère à deviner.
        /// </summary>
        /// <param name="listHiraganaToGuess"></param>
        /// <param name="listKatakanaToGuess"></param>
        /// <param name="hiragana"></param>
        /// <param name="katakana"></param>
        /// <param name="categories"></param>
        /// <param name="toGuess"></param>
        /// <param name="fontName"></param>
        /// <param name="eligibleFonts"></param>
        public void generateKanaToGuess(ref List<Kana> listHiraganaToGuess, ref List<Kana> listKatakanaToGuess, bool hiragana, 
            bool katakana, List<bool> categories, ref Kana toGuess, ref string fontName, List<Font> eligibleFonts)
        {
            Random rand = new Random();

            if (listHiraganaToGuess.Count == 0)
                listHiraganaToGuess = Kana.initialiseAllKana(categories).Where(x => !String.IsNullOrEmpty(x.unicodeHiragana)).ToList();

            // Pas besoin de trier les katakanas car tous les Hiragana existent en Katakana, et il y en a même quelques uns en plus.
            if (listKatakanaToGuess.Count == 0)
                listKatakanaToGuess = Kana.initialiseAllKana(categories);

            Console.WriteLine("Hiragana : " + listHiraganaToGuess.Count());

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
        /// <param name="listKana"></param>
        /// <param name="resultEnum"></param>
        /// <param name="toGuess"></param>
        /// <param name="fontName"></param>
        /// <param name="eligibleFonts"></param>
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
