namespace ApprentissageKana.Services
{
    public class DatabaseService
    {
        private DAL.KanaContext kanaDB = new DAL.KanaContext();
        
        public DatabaseService() { }

        /// <summary>
        /// Permet de créer un nouveau compte en base
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void AddUser (string username, string password)
        {
            String hash = Utils.Fonctions.GetHash(username, password);
            DAL.Models.Users utilisateur = new DAL.Models.Users { username = username, password = hash, creationAccountDate = DateTime.Now, lastConnectionDate = DateTime.Now };
            kanaDB.Users.Add(utilisateur);
            kanaDB.SaveChanges();
        }

        /// <summary>
        /// Permet de vérifier qu’un compte avec le même nom n’existe pas encore
        /// </summary>
        /// <param name="username">Nom du compte</param>
        /// <returns></returns>
        public bool UserExist(string username)
        {
            DAL.Models.Users utilisateur = kanaDB.Users.SingleOrDefault(x => x.username == username);
            bool retour = true;

            if (utilisateur == null)
                retour = false;
            
            return retour;
        }

        /// <summary>
        /// Permet de vérifier que l’utilisateur existe bien en base
        /// </summary>
        /// <param name="username">Nom du compte</param>
        /// <param name="password">Mot de passe</param>
        /// <returns></returns>
        public bool UserExist (string username, string password)
        {
            String hash = Utils.Fonctions.GetHash(username, password);
            DAL.Models.Users utilisateur = kanaDB.Users.SingleOrDefault(x => x.username == username && x.password == hash);
            bool retour = true;

            if (utilisateur == null)
                retour = false;
            else
            {
                utilisateur.lastConnectionDate = DateTime.Now;
                kanaDB.SaveChanges();
            }

            return retour;
        }
    }
}
