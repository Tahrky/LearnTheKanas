namespace ApprentissageKana.Services
{
    public class DatabaseService
    {
        private DAL.KanaContext kanaDB = new DAL.KanaContext();
        
        public DatabaseService() { }

        public void AddUser (string username, string password)
        {
            String hash = Utils.Fonctions.GetHash(username, password);
            DAL.Models.Users utilisateur = new DAL.Models.Users { username = username, password = hash, creationAccountDate = DateTime.Now, lastConnectionDate = DateTime.Now };
            kanaDB.Users.Add(utilisateur);
            kanaDB.SaveChanges();
        }
    }
}
