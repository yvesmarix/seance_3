namespace seance_3;

public class UtilisateurManager
{
    private List<Utilisateur> Utilisateurs;
    private static UtilisateurManager utilisateurManager;

    public static UtilisateurManager Instance
    {
        get
        {
            if (utilisateurManager == null) utilisateurManager = new UtilisateurManager();
            return utilisateurManager;
        }
    }

    public void Create(Utilisateur utilisateur)
    {
        // Logique de vérification de doublons
        Utilisateurs.Add(utilisateur);
    }

    public Utilisateur? Get(string email)
    {
        return Utilisateurs
            .Where(p => p.Adresse == email)
            .FirstOrDefault();
    }
}
