namespace seance_3
{
    public class CompteCourantDevise : CompteCourant
    {
        public string Devise { get; set; } = "€";
        public double SoldeEnDevise { get; set; } = 0;
        public double FxRate { get; set; } = 0;

        public CompteCourantDevise(Utilisateur utilisateur, double solde, string devise, double fxrate) : base(utilisateur, solde)
        {
            Devise = devise;
            FxRate = fxrate;
        }

        public void CalculSoldeDevise()
        {
            SoldeEnDevise = Solde * FxRate;
        }
    }

}