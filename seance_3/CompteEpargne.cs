namespace seance_3
{
    public class CompteEpargne : CompteCourant
    {
        // static différent de constante car static est changeable à partir d'une BDD
        // alors que const est figé
        private const double Taux = 0.04;
        private static double TauxInteret = 0.03;
        public void CalculInteret(double interest)
        {
            Mouvement(TauxInteret * Solde / 365.0,
            "intérêt du jour");
        }

        public CompteEpargne(Utilisateur utilisateur, double solde) : base(utilisateur, solde)
        {
        }
    }
}