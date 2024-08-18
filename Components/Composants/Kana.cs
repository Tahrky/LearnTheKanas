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

        public static List<Kana> initialiseAllKana (bool kana = true, bool daikuten = false, bool combo = false)
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

            Kana diacriticDakuten = new Kana
            {
                nom = "dakuten ",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u3099",
                unicodeKatakana = "\u3099",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana diacriticHandakuten = new Kana
            {
                nom = "handakuten",
                poids = 1,
                categorie = 0,
                unicodeHiragana = "\u309A",
                unicodeKatakana = "\u309A",
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ga = new Kana
            {
                nom = "ga",
                poids = 1,
                categorie = 0,
                unicodeHiragana = ka.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = ka.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana gi = new Kana
            {
                nom = "gi",
                poids = 1,
                categorie = 0,
                unicodeHiragana = ki.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = ki.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana gu = new Kana
            {
                nom = "gu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = ku.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = ku.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ge = new Kana
            {
                nom = "ge",
                poids = 1,
                categorie = 0,
                unicodeHiragana = ke.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = ke.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana go = new Kana
            {
                nom = "go",
                poids = 1,
                categorie = 0,
                unicodeHiragana = ko.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = ko.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana za = new Kana
            {
                nom = "za",
                poids = 1,
                categorie = 0,
                unicodeHiragana = sa.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = sa.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ji = new Kana
            {
                nom = "ji",
                poids = 1,
                categorie = 0,
                unicodeHiragana = shi.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = shi.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana zu = new Kana
            {
                nom = "zu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = su.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = su.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ze = new Kana
            {
                nom = "ze",
                poids = 1,
                categorie = 0,
                unicodeHiragana = se.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = se.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana zo = new Kana
            {
                nom = "zo",
                poids = 1,
                categorie = 0,
                unicodeHiragana = so.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = so.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana da = new Kana
            {
                nom = "da",
                poids = 1,
                categorie = 0,
                unicodeHiragana = ta.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = ta.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana dji = new Kana
            {
                nom = "dji",
                poids = 1,
                categorie = 0,
                unicodeHiragana = chi.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = chi.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana dzu = new Kana
            {
                nom = "dzu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = tsu.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = tsu.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana de = new Kana
            {
                nom = "de",
                poids = 1,
                categorie = 0,
                unicodeHiragana = te.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = te.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana doKana = new Kana
            {
                nom = "do",
                poids = 1,
                categorie = 0,
                unicodeHiragana = to.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = to.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana ba = new Kana
            {
                nom = "ba",
                poids = 1,
                categorie = 0,
                unicodeHiragana = ha.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = ha.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana bi = new Kana
            {
                nom = "bi",
                poids = 1,
                categorie = 0,
                unicodeHiragana = hi.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = hi.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana bu = new Kana
            {
                nom = "bu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = fu.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = fu.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana be = new Kana
            {
                nom = "be",
                poids = 1,
                categorie = 0,
                unicodeHiragana = he.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = he.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana bo = new Kana
            {
                nom = "bo",
                poids = 1,
                categorie = 0,
                unicodeHiragana = ho.unicodeHiragana + diacriticDakuten.unicodeHiragana,
                unicodeKatakana = ho.unicodeKatakana + diacriticDakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana pa = new Kana
            {
                nom = "pa",
                poids = 1,
                categorie = 0,
                unicodeHiragana = ha.unicodeHiragana + diacriticHandakuten.unicodeHiragana,
                unicodeKatakana = ha.unicodeKatakana + diacriticHandakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana pi = new Kana
            {
                nom = "pi",
                poids = 1,
                categorie = 0,
                unicodeHiragana = hi.unicodeHiragana + diacriticHandakuten.unicodeHiragana,
                unicodeKatakana = hi.unicodeKatakana + diacriticHandakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana pu = new Kana
            {
                nom = "pu",
                poids = 1,
                categorie = 0,
                unicodeHiragana = fu.unicodeHiragana + diacriticHandakuten.unicodeHiragana,
                unicodeKatakana = fu.unicodeKatakana + diacriticHandakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana pe = new Kana
            {
                nom = "pe",
                poids = 1,
                categorie = 0,
                unicodeHiragana = he.unicodeHiragana + diacriticHandakuten.unicodeHiragana,
                unicodeKatakana = he.unicodeKatakana + diacriticHandakuten.unicodeHiragana,
                aideHiragana = "",
                aideKatakana = "",
            };

            Kana po = new Kana
            {
                nom = "po",
                poids = 1,
                categorie = 0,
                unicodeHiragana = ho.unicodeHiragana + diacriticHandakuten.unicodeHiragana,
                unicodeKatakana = ho.unicodeKatakana + diacriticHandakuten.unicodeHiragana,
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
                wa,        n,       wo,
            };

            List<Kana> allDaikutenKanas = new List<Kana> {
                ga,  gi,  gu,  ge,  go,
                za,  ji,  zu,  ze,  zo,
                da, dji, dzu,  de,  doKana,
                ba,  bi,  bu,  be,  bo,
                pa,  pi,  pu,  pe,  po,
            };

            List<Kana> returnList = new List<Kana> ();

            if (kana)
                returnList.AddRange (allKanas);

            if (daikuten)
                returnList.AddRange(allDaikutenKanas);

            if (combo)
                returnList.Add(null);

            return returnList;
        }
    }
}
