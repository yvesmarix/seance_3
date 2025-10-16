using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seance_3
{
    public class MouvementCompte
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string Type { get; set; }
        public double Montant { get; set; }

        public MouvementCompte(string type, double montant)
        {
            Type = type;
            Montant = montant;
        }
    }
}
