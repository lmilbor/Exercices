using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicules
{
    public class Vehicule
    {
        #region Propriétés

        public string Nom { get; }
        public int NbRoues { get; }
        public energies Energie { get; }
        public virtual string Description
        {
            get { return string.Format("Véhicule {0} roule sur {1} roues et à l'énergie {2}", Nom, NbRoues, Energie) ; }
        }

        #endregion
        public Vehicule(string nom, int nbRoues, energies energie)
        {
            Nom = nom;
            NbRoues = nbRoues;
            Energie = energie;
        }
    }

    public class Voiture : Vehicule
    {
        public override string Description
        {
            get { return string.Format("Je suis une voiture \r\n") + base.Description ; }
        }
        public Voiture(string nom, energies energie) : base(nom, 4, energie) { }
    }

    public class Moto : Vehicule
    {
        public override string Description
        {
            get { return string.Format("Je suis une moto \r\n") + base.Description; }
        }
        public Moto(string nom, energies energie) :base(nom, 2, energie)
        {

        }
    }
}
