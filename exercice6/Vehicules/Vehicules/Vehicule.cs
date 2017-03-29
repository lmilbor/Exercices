using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicules
{
    public abstract class Vehicule : IComparable
    {
        #region Propriétés

        public string Nom { get; }
        public int NbRoues { get; }
        public energies Energie { get; }
        public virtual string Description
        {
            get { return string.Format("Véhicule {0} roule sur {1} roues et à l'énergie {2}", Nom, NbRoues, Energie) ; }
        }

        public abstract void CalculerConso();

        public int CompareTo(object obj)
        {
            if (obj is Vehicule)
                if (PRK < ((Vehicule)obj).PRK)
                    return 1;
                else if (PRK == ((Vehicule)obj).PRK)
                    return 0;
                else
                    return -1;
            else
                throw new FormatException("L'objet entrez n'est pas du type Vehicule.");
        }

        public abstract double PRK { get; }
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

        public override void CalculerConso()
        {
            throw new NotImplementedException();
        }

        public override double PRK
        {
           get { return 0.40; }
        }

        public string RefaireParallélisme()
        {
            return "Parallélisme refait";
        }
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

        public override void CalculerConso()
        {
            throw new NotImplementedException();
        }

        public override double PRK
        {
            get { return 0.35; }
        }
    }
}
