using System.Security.Cryptography;

namespace ApprentissageKana.Utils
{
    public class Fonctions
    {
        public static String GetHash(String username, String password)
        {
            SHA512 motDePasse = SHA512.Create();
            byte[] hash = motDePasse.ComputeHash(System.Text.Encoding.ASCII.GetBytes(username + Configuration.GrainDeSable + password));
            String retour = Convert.ToHexString(hash).Substring(0, Convert.ToHexString(hash).Length / 2);

            return retour;
        }
    }
}
