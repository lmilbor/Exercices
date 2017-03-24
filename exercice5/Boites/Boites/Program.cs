using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boites
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    #region Types
    /// <summary>
    /// Définit un type couleur : blanc, orange, bleu, rouge, vert, marron, jaune.
    /// </summary>
    public enum couleur
    {
        blanc, orange,
        bleu, rouge,
        vert, marron,
        jaune
    }

    /// <summary>
    /// Définit un type matière : carton, plastique, bois, metal.
    /// </summary>
    public enum matiere
    {
        carton, bois,
        plastique, metal
    }
    #endregion

    public class Boite
    {
        #region champs privés
        private double _hauteur = 30;
        private double _longueur = 30;
        private double _largeur = 30;
        private couleur _couleur;
        private matiere _matiere = matiere.carton;
        #endregion

        public Boite()
        {
            _hauteur = 30;
            _largeur = 30;
            _longueur = 30;
            _matiere = matiere.carton;
        }

        #region propriété
        /// <summary>
        /// Retourne la hauteur de la boite.
        /// </summary>
        public double Hauteur
        {
            get {return _hauteur; }
        }

        /// <summary>
        /// Retourne la largeur de la boite.
        /// </summary>
        public double Largeur
        {
            get { return _largeur; }
        }

        /// <summary>
        /// Retourne la longueur de la boite.
        /// </summary>
        public double Longueur
        {
            get { return _longueur; }
        }

        /// <summary>
        /// Retourne la couleur de la boite et permet de la choisir.
        /// </summary>
        public couleur Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        /// <summary>
        /// Retourne la matière de la boite.
        /// </summary>
        public matiere Matiere
        {
            get { return _matiere; }
        }

        /// <summary>
        /// Retourne le volume de la boite.
        /// </summary>
        public double Volume
        {
            get { return _hauteur * _largeur * _longueur; }
        }
        #endregion

        #region methodes publiques
        /// <summary>
        /// Cette fonctionnalité n'est pas encore disponible.
        /// </summary>
        /// <param name="destinataire"></param>
        public void Etiqueter(string destinataire)
        {
            throw new NotImplementedException("Cette fonctionnalité n'est pas encore disponible.");
        }

        /// <summary>
        /// Cette fonctionnalité n'est pas encore disponible.
        /// </summary>
        /// <param name="destinataire"></param>
        /// <param name="fragile"></param>
        public void Etiqueter(string destinataire, bool fragile)
        {
            throw new NotImplementedException("Cette fonctionnalité n'est pas encore disponible.");
        }
        #endregion
    }
}
