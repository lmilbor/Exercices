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

        public double Prix { get; }
        public string Nom { get; }
        public int NbRoues { get; }
        public energies Energie { get; }
        public virtual string Description
        {
            get { return string.Format("Véhicule {0} roule sur {1} roues et à l'énergie {2}", Nom, NbRoues, Energie) ; }
        }
        public abstract double PRK { get; }
        #endregion

        #region Constructeurs

        public Vehicule(string nom, int nbRoues, energies energie)
        {
            Nom = nom;
            NbRoues = nbRoues;
            Energie = energie;
        }

        public Vehicule(string nom, double prix)
        {
            Nom = nom;
            Prix = prix;
        }
        #endregion

        #region Méthodes

        public abstract void CalculerConso();

        public int CompareTo(object obj)
        {
            if (obj is Vehicule)
            {
                if (Prix< ((Vehicule)obj).Prix)
                    return 1;
                else if (Prix == ((Vehicule)obj).Prix)
                    return 0;
                else
                    return -1;
            }
            else
                throw new ArgumentException("L'objet entrez n'est pas du type Vehicule.");
        }

        #endregion
    }
    public class Voiture : Vehicule
    {
        #region Propriétés

        public override string Description
        {
            get { return string.Format("Je suis une voiture \r\n") + base.Description ; }
        }

        #endregion

        #region Constructeurs

        public Voiture(string nom, energies energie) : base(nom, 4, energie) { }
        public Voiture(string nom, double prix) :base(nom, prix) { }
        #endregion

        #region Méthodes

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
        #endregion
    }

    public class Moto : Vehicule
    {
        #region Propriétés
        public override string Description
        {
            get { return string.Format("Je suis une moto \r\n") + base.Description; }
        }
        #endregion

        #region Constructeurs
        public Moto(string nom, energies energie) :base(nom, 2, energie){ }
        public Moto(string nom, double prix) :base(nom, prix) { }
        #endregion

        #region Méthodes
        public override void CalculerConso()
        {
            throw new NotImplementedException();
        }

        public override double PRK
        {
            get { return 0.35; }
        }
        #endregion
    }
}
