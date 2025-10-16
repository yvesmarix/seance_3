namespace seance_3;

public class Utilisateur
{
    public int Id { get; set; }
    public string Prenom { get; set; } = "";
    public string Nom { get; set; } = "";
    public string Adresse { get; set; } = "";
    public string VilleNaissance { get; set; } = "";

    // public Utilisateur(int id, string prenom, string nom, string adresse, string villenaissance)
    // {
    //     Id = id; Prenom = prenom; Nom = nom; Adresse = adresse; VilleNaissance = villenaissance;
    // }
}