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
        public string nom;
        public double poids;
        public Categorie categorie;
        public string unicodeHiragana;

        public static List<Kana> initialiseAllKana ()
        {
            Kana a = new Kana
            {
                nom = "a",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3042",
            };

            Kana i = new Kana
            {
                nom = "i",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3044",
            };

            Kana u = new Kana
            {
                nom = "u",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3046",
            };

            Kana e = new Kana
            {
                nom = "e",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3048",
            };

            Kana o = new Kana
            {
                nom = "o",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u304A",
            };

            Kana ka = new Kana
            {
                nom = "ka",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u304B",
            };

            Kana ki = new Kana
            {
                nom = "ki",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u304D",
            };

            Kana ku = new Kana
            {
                nom = "ku",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u304F",
            };

            Kana ke = new Kana
            {
                nom = "ke",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3051",
            };

            Kana ko = new Kana
            {
                nom = "ko",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3053",
            };

            Kana sa = new Kana
            {
                nom = "sa",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3055",
            };

            Kana shi = new Kana
            {
                nom = "si",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3057",
            };

            Kana su = new Kana
            {
                nom = "su",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3059",
            };

            Kana se = new Kana
            {
                nom = "se",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u305B",
            };

            Kana so = new Kana
            {
                nom = "so",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u305D",
            };

            Kana ta = new Kana
            {
                nom = "ta",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u305F",
            };

            Kana chi = new Kana
            {
                nom = "chi",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3061",
            };

            Kana tsu = new Kana
            {
                nom = "a",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3064",
            };

            Kana te = new Kana
            {
                nom = "te",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3066",
            };

            Kana to = new Kana
            {
                nom = "to",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3068",
            };

            Kana na = new Kana
            {
                nom = "na",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306A",
            };

            Kana ni = new Kana
            {
                nom = "ni",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306B",
            };

            Kana nu = new Kana
            {
                nom = "nu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306C",
            };

            Kana ne = new Kana
            {
                nom = "ne",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306D",
            };

            Kana no = new Kana
            {
                nom = "no",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306E",
            };

            Kana ha = new Kana
            {
                nom = "ha",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306F",
            };

            Kana hi = new Kana
            {
                nom = "hi",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3072",
            };

            Kana fu = new Kana
            {
                nom = "fu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3075",
            };

            Kana he = new Kana
            {
                nom = "he",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3078",
            };

            Kana ho = new Kana
            {
                nom = "ho",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u307B",
            };

            Kana ma = new Kana
            {
                nom = "ma",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u307E",
            };

            Kana mi = new Kana
            {
                nom = "mi",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u307F",
            };

            Kana mu = new Kana
            {
                nom = "mu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3080",
            };

            Kana me = new Kana
            {
                nom = "me",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3081",
            };

            Kana mo = new Kana
            {
                nom = "mo",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3082",
            };

            Kana ya = new Kana
            {
                nom = "ya",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3084",
            };

            Kana yu = new Kana
            {
                nom = "yu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3086",
            };

            Kana yo = new Kana
            {
                nom = "yo",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3088",
            };

            Kana ra = new Kana
            {
                nom = "ra",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3089",
            };

            Kana ri = new Kana
            {
                nom = "ri",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u308A",
            };

            Kana ru = new Kana
            {
                nom = "ru",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u308B",
            };

            Kana re = new Kana
            {
                nom = "re",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u308C",
            };

            Kana ro = new Kana
            {
                nom = "ro",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u308D",
            };

            Kana wa = new Kana
            {
                nom = "wa",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u308F",
            };

            Kana wo = new Kana
            {
                nom = "wo",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3092",
            };

            Kana n = new Kana
            {
                nom = "n",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3093",
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
