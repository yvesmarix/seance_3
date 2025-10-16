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

        public void Deposer(double montant)
        {
            Mouvement(montant, "Depot");
        }


        public void Retrait(double montant)
        {
            Mouvement(-montant, "Retrait");
        }

        public virtual void Virement(double montant, Compte destinataire)
        {
            if (Solde >= montant)
            {
                Retrait(montant);
                destinataire.Deposer(montant);
            }
            else
                throw new Exception("Le montant du virement est supérieur au solde du compte.");
        }
    }
}