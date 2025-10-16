namespace seance_3
{
    // Petite classe de démonstration
    public class Voiture
    {
        public string Couleur { get; } = "Bleu";
        public double VitesseMaximale { get; } = 100;
        // une fois la valeur défini pour une constante, on ne peut plus la modifier
        private const double ConversionKmMiles = 0.621;
        public double VitesseMaximaleMiles
        {
            get { return VitesseMaximale * ConversionKmMiles; }
        }
        // par défaut à 0 quand double
        public double DistanceParcourue { get; set; }

        // constructeur
        public Voiture(string Couleur, double VitesseMaximale, double DistanceParcourue)
        {
            this.Couleur = Couleur;
            this.VitesseMaximale = VitesseMaximale;
            this.DistanceParcourue = DistanceParcourue;
        }

        // acceptation des nulls
        public Voiture(string? couleur = null)
        {
            if (couleur != null) this.Couleur = couleur;
        }
        public void AddTrajet(double distance)
        {
            DistanceParcourue += distance;
        }
        public void Trajet(string distance)
        {
            if (distance.Contains("km"))
                AddTrajet(double.Parse(distance.Replace("km", "")));
            else if (distance.Contains("miles"))
                AddTrajet(double.Parse(distance.Replace("miles", "")) /
                ConversionKmMiles);
            else
                throw new Exception("Données invalides ...");
        }

    }

}