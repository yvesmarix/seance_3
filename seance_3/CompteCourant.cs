using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seance_3
{
    public class CompteCourant : Compte
    {
        public Utilisateur Utilisateur { get; private set; }
        public CompteCourant(Utilisateur utilisateur, double solde = 0)
        {
            Utilisateur = utilisateur;
            Solde = solde;
        }

        // constructeur bidon pour les tests
        public CompteCourant()
        {
            Utilisateur = new Utilisateur();
        }
    }
}
