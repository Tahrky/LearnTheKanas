namespace ApprentissageKana.Components.Composants
{
    public enum Categorie
    {
        Normal = 0,
        Diacritic = 1,
        Combo = 2,
        ComboDiacritic = 3
    }

    public enum KanaEnum
    {
        Hiragana = 0,
        Katakana = 1
    }

    public class Kana
    {
        public string nom = String.Empty;
        public double poids;

        // Catégorie du Kana
        public Categorie categorie;

        // Permet de savoir si l’affichage doit-être en Hiragana ou Katakana
        public KanaEnum kanaEnum;

        // Code Unicode correspondant à la syllabe
        public string unicodeHiragana = String.Empty;
        public string unicodeKatakana = String.Empty;

        public string aideHiragana = String.Empty;
        public string aideKatakana = String.Empty;

        public string texteAAfficher = String.Empty;
        public string aideAAfficher = String.Empty;

        public static List<Kana> initialiseAllKana ()
        {
            Kana a = new Kana
            {
                nom = "a",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3042",
                unicodeKatakana = "\u30A2",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana i = new Kana
            {
                nom = "i",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3044",
                unicodeKatakana = "\u30A4",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana u = new Kana
            {
                nom = "u",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3046",
                unicodeKatakana = "\u30A6",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana e = new Kana
            {
                nom = "e",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3048",
                unicodeKatakana = "\u30A8",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana o = new Kana
            {
                nom = "o",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u304A",
                unicodeKatakana = "\u30AA",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ka = new Kana
            {
                nom = "ka",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u304B",
                unicodeKatakana = "\u30AB",
                aideHiragana = "Catapulte",
                aideKatakana = "Catapulte",
            };

            Kana ki = new Kana
            {
                nom = "ki",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u304D",
                unicodeKatakana = "\u30AD",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ku = new Kana
            {
                nom = "ku",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u304F",
                unicodeKatakana = "\u30AF",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ke = new Kana
            {
                nom = "ke",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3051",
                unicodeKatakana = "\u30B1",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ko = new Kana
            {
                nom = "ko",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3053",
                unicodeKatakana = "\u30B3",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana sa = new Kana
            {
                nom = "sa",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3055",
                unicodeKatakana = "\u30B5",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana shi = new Kana
            {
                nom = "shi",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3057",
                unicodeKatakana = "\u30B7",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana su = new Kana
            {
                nom = "su",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3059",
                unicodeKatakana = "\u30B9",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana se = new Kana
            {
                nom = "se",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u305B",
                unicodeKatakana = "\u30BB",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana so = new Kana
            {
                nom = "so",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u305D",
                unicodeKatakana = "\u30BD",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ta = new Kana
            {
                nom = "ta",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u305F",
                unicodeKatakana = "\u30BF",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana chi = new Kana
            {
                nom = "chi",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3061",
                unicodeKatakana = "\u30C1",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana tsu = new Kana
            {
                nom = "tsu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3064",
                unicodeKatakana = "\u30C4",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana te = new Kana
            {
                nom = "te",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3066",
                unicodeKatakana = "\u30C6",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana to = new Kana
            {
                nom = "to",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3068",
                unicodeKatakana = "\u30C8",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana na = new Kana
            {
                nom = "na",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306A",
                unicodeKatakana = "\u30CA",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ni = new Kana
            {
                nom = "ni",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306B",
                unicodeKatakana = "\u30CB",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana nu = new Kana
            {
                nom = "nu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306C",
                unicodeKatakana = "\u30CC",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ne = new Kana
            {
                nom = "ne",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306D",
                unicodeKatakana = "\u30CD",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana no = new Kana
            {
                nom = "no",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306E",
                unicodeKatakana = "\u30CE",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ha = new Kana
            {
                nom = "ha",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u306F",
                unicodeKatakana = "\u30CF",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana hi = new Kana
            {
                nom = "hi",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3072",
                unicodeKatakana = "\u30D2",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana fu = new Kana
            {
                nom = "fu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3075",
                unicodeKatakana = "\u30D5",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana he = new Kana
            {
                nom = "he",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3078",
                unicodeKatakana = "\u30D8",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ho = new Kana
            {
                nom = "ho",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u307B",
                unicodeKatakana = "\u30DB",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ma = new Kana
            {
                nom = "ma",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u307E",
                unicodeKatakana = "\u30DE",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana mi = new Kana
            {
                nom = "mi",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u307F",
                unicodeKatakana = "\u30DF",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana mu = new Kana
            {
                nom = "mu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3080",
                unicodeKatakana = "\u30E0",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana me = new Kana
            {
                nom = "me",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3081",
                unicodeKatakana = "\u30E1",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana mo = new Kana
            {
                nom = "mo",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3082",
                unicodeKatakana = "\u30E2",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ya = new Kana
            {
                nom = "ya",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3084",
                unicodeKatakana = "\u30E4",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana yu = new Kana
            {
                nom = "yu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3086",
                unicodeKatakana = "\u30E6",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana yo = new Kana
            {
                nom = "yo",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3088",
                unicodeKatakana = "\u30E8",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ra = new Kana
            {
                nom = "ra",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3089",
                unicodeKatakana = "\u30E9",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ri = new Kana
            {
                nom = "ri",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u308A",
                unicodeKatakana = "\u30EA",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ru = new Kana
            {
                nom = "ru",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u308B",
                unicodeKatakana = "\u30EB",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana re = new Kana
            {
                nom = "re",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u308C",
                unicodeKatakana = "\u30EC",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ro = new Kana
            {
                nom = "ro",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u308D",
                unicodeKatakana = "\u30ED",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana wa = new Kana
            {
                nom = "wa",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u308F",
                unicodeKatakana = "\u30EF",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana wo = new Kana
            {
                nom = "wo",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3092",
                unicodeKatakana = "\u30F2",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana n = new Kana
            {
                nom = "n",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3093",
                unicodeKatakana = "\u30F3",
                aideHiragana = "",
                aideKatakana = "",
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
