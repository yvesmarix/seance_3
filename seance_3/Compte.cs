namespace seance_3
{
    public abstract class Compte
    {
        public double Solde { get; protected set; }
        // regarder diff entre private et protected
        public Compte(double solde = 0.0)
        {
            Solde = solde;
        }
        private List<MouvementCompte> Mouvements { get; set; }
                            = new List<MouvementCompte>();

        protected void Mouvement(double montant, string typeMouvement = "")
        {
            Mouvements.Add(new MouvementCompte(typeMouvement, montant));
            Solde += montant;
        }

        public void Deposer(double montant, string? libelle = null)
        {
            Mouvement(montant, libelle == null ? "Depot" : libelle);
        }


        public void Retrait(double montant, string? libelle = null)
        {
            Mouvement(-montant, libelle == null ? "Retrait" : libelle);
        }

        public bool Virement(double montant, Compte destinataire)
        {
            if (Solde >= montant)
            {
                Retrait(montant, "Virement Sortant");
                destinataire.Deposer(montant, "Virement Entrant");
                return true;
            }
            else
                throw new Exception("Le montant du virement est supérieur au solde du compte.");
        }
    }
}