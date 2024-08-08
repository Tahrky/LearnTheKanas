using ApprentissageKana.Components.Utils;

namespace ApprentissageKana.Components
{
    public enum Categorie
    {
        Normal = 0,
        Diacritic = 1,
        Combo = 2,
        ComboDiacritic = 3
    }

    public class Kana
    {
        public string nom = String.Empty;
        public double poids;
        public Categorie categorie;
        public string unicodeHiragana = String.Empty;
        public string unicodeKatakana = String.Empty;

        public static List<Kana> initialiseAllKana ()
        {
            Kana a = new Kana
            {
                nom = "a",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3042",
                unicodeKatakana = "\u30A2",
            };

            Kana i = new Kana
            {
                nom = "i",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3044",
                unicodeKatakana = "\u30A4",
            };

            Kana u = new Kana
            {
                nom = "u",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3046",
                unicodeKatakana = "\u30A6",
            };

            Kana e = new Kana
            {
                nom = "e",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3048",
                unicodeKatakana = "\u30A8",
            };

            Kana o = new Kana
            {
                nom = "o",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u304A",
                unicodeKatakana = "\u30AA",
            };

            Kana ka = new Kana
            {
                nom = "ka",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u304B",
                unicodeKatakana = "\u30AB",
            };

            Kana ki = new Kana
            {
                nom = "ki",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u304D",
                unicodeKatakana = "\u30AD",
            };

            Kana ku = new Kana
            {
                nom = "ku",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u304F",
                unicodeKatakana = "\u30AF",
            };

            Kana ke = new Kana
            {
                nom = "ke",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3051",
                unicodeKatakana = "\u30B1",
            };

            Kana ko = new Kana
            {
                nom = "ko",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3053",
                unicodeKatakana = "\u30B3",
            };

            Kana sa = new Kana
            {
                nom = "sa",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3055",
                unicodeKatakana = "\u30B5",
            };

            Kana shi = new Kana
            {
                nom = "shi",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3057",
                unicodeKatakana = "\u30B7",
            };

            Kana su = new Kana
            {
                nom = "su",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3059",
                unicodeKatakana = "\u30B9",
            };

            Kana se = new Kana
            {
                nom = "se",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u305B",
                unicodeKatakana = "\u30BB",
            };

            Kana so = new Kana
            {
                nom = "so",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u305D",
                unicodeKatakana = "\u30BD",
            };

            Kana ta = new Kana
            {
                nom = "ta",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u305F",
                unicodeKatakana = "\u30BF",
            };

            Kana chi = new Kana
            {
                nom = "chi",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3061",
                unicodeKatakana = "\u30C1",
            };

            Kana tsu = new Kana
            {
                nom = "tsu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3064",
                unicodeKatakana = "\u30C4",
            };

            Kana te = new Kana
            {
                nom = "te",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3066",
                unicodeKatakana = "\u30C6",
            };

            Kana to = new Kana
            {
                nom = "to",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3068",
                unicodeKatakana = "\u30C8",
            };

            Kana na = new Kana
            {
                nom = "na",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306A",
                unicodeKatakana = "\u30CA",
            };

            Kana ni = new Kana
            {
                nom = "ni",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306B",
                unicodeKatakana = "\u30CB",
            };

            Kana nu = new Kana
            {
                nom = "nu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306C",
                unicodeKatakana = "\u30CC",
            };

            Kana ne = new Kana
            {
                nom = "ne",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306D",
                unicodeKatakana = "\u30CD",
            };

            Kana no = new Kana
            {
                nom = "no",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306E",
                unicodeKatakana = "\u30CE",
            };

            Kana ha = new Kana
            {
                nom = "ha",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306F",
                unicodeKatakana = "\u30CF",
            };

            Kana hi = new Kana
            {
                nom = "hi",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3072",
                unicodeKatakana = "\u30D2",
            };

            Kana fu = new Kana
            {
                nom = "fu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3075",
                unicodeKatakana = "\u30D5",
            };

            Kana he = new Kana
            {
                nom = "he",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3078",
                unicodeKatakana = "\u30D8",
            };

            Kana ho = new Kana
            {
                nom = "ho",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u307B",
                unicodeKatakana = "\u30DB",
            };

            Kana ma = new Kana
            {
                nom = "ma",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u307E",
                unicodeKatakana = "\u30DE",
            };

            Kana mi = new Kana
            {
                nom = "mi",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u307F",
                unicodeKatakana = "\u30DF",
            };

            Kana mu = new Kana
            {
                nom = "mu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3080",
                unicodeKatakana = "\u30E0",
            };

            Kana me = new Kana
            {
                nom = "me",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3081",
                unicodeKatakana = "\u30E1",
            };

            Kana mo = new Kana
            {
                nom = "mo",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3082",
                unicodeKatakana = "\u30E2",
            };

            Kana ya = new Kana
            {
                nom = "ya",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3084",
                unicodeKatakana = "\u30E4",
            };

            Kana yu = new Kana
            {
                nom = "yu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3086",
                unicodeKatakana = "\u30E6",
            };

            Kana yo = new Kana
            {
                nom = "yo",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3088",
                unicodeKatakana = "\u30E8",
            };

            Kana ra = new Kana
            {
                nom = "ra",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3089",
                unicodeKatakana = "\u30E9",
            };

            Kana ri = new Kana
            {
                nom = "ri",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u308A",
                unicodeKatakana = "\u30EA",
            };

            Kana ru = new Kana
            {
                nom = "ru",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u308B",
                unicodeKatakana = "\u30EB",
            };

            Kana re = new Kana
            {
                nom = "re",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u308C",
                unicodeKatakana = "\u30EC",
            };

            Kana ro = new Kana
            {
                nom = "ro",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u308D",
                unicodeKatakana = "\u30ED",
            };

            Kana wa = new Kana
            {
                nom = "wa",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u308F",
                unicodeKatakana = "\u30EF",
            };

            Kana wo = new Kana
            {
                nom = "wo",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3092",
                unicodeKatakana = "\u30F2",
            };

            Kana n = new Kana
            {
                nom = "n",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3093",
                unicodeKatakana = "\u30F3",
            };

            List<Kana> allKanas = new List<Kana> {
                a,    i,   u,   e,   o,
                ka,  ki,  ku,  ke,  ko,
                sa, shi,  su,  se,  so,
                ta, chi, tsu,  te,  to,
                na,  ni,  nu,  ne,  no,
                ha,  hi,  fu,  he,  ho,
                ma,  mi,  mu,  me,  mo,
                ya,       yu,       yo,
                ra,  ri,  ru,  re,  ro,
                wa,        n,       wo
            };

            return allKanas;
        }
    }
}
