using POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBanquaire
{
    public abstract class Décorateur : MoyenPaiement
    {
        protected MoyenPaiement moyenPaiement;

        // Constructeur
        public Décorateur(MoyenPaiement moyenPaiementIn)
        {
            moyenPaiement = moyenPaiementIn;
        }
    }

    public class Prevenable : Décorateur
    {
        public Prevenable()
        {

        }

        public override string Payer()
        {
            throw new NotImplementedException();
        }
    }
}
