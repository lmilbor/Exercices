using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boites
{
    #region Types
    /// <summary>
    /// Définit un type couleur : blanc, orange, bleu, rouge, vert, marron, jaune.
    /// </summary>
    public enum couleurs
    {
        blanc, orange,
        bleu, rouge,
        vert, marron,
        jaune
    }

    /// <summary>
    /// Définit un type matière : carton, plastique, bois, metal.
    /// </summary>
    public enum matieres
    {
        carton, bois,
        plastique, metal
    }

    #endregion
    public class Boite
    {
        #region champs privés
        private static int _compteurBoite = 0;
        private double _hauteur;
        private double _longueur;
        private double _largeur;
        private Etiquette _etiquetteDest;
        private Etiquette _etiquetteFragile;
        //private couleurs _couleur; // définit par defaut lorsqu'on crée les propriétés Couleur et Matiere
        //private matieres _matiere;
        #endregion

        #region propriété

        /// <summary>
        /// Retourne la liste d'article contenur dans la boite.
        /// </summary>
        public List<Article> Articles { get; } // Comme ça on a une list qui ne contient QUE des articles 
                                              //(pas de transtypage nécessaire comme avec la propriété qui suit.
        //public ArrayList Articles { get; }

        /// <summary>
        /// Retourne la hauteur de la boite.
        /// </summary>
        public double Hauteur
        {
            get { return _hauteur; }
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
        public couleurs Couleur { get ; set; } // C'est equivalent au code commenté qui suit.
        /*public couleur Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }*/

        /// <summary>
        /// Retourne la matière de la boite.
        /// </summary>
        public matieres Matiere { get; } // C'est equivalent au code commenté qui suit.

        //public matiere Matiere
        //{
        //    get { return _matiere; }
        //}

        /// <summary>
        /// Retourne le volume de la boite.
        /// </summary>
        public double Volume
        {
            get { return _hauteur * _largeur * _longueur; }
        }

        /// <summary>
        /// Retourne le nombre de boîtes crées.
        /// </summary>
        public static int CompteurBoite { get { return _compteurBoite; } }

        /// <summary>
        /// Retourne l'etiquette de déstinataire.
        /// </summary>
        public Etiquette EtiquetteDest
        {
            get {return _etiquetteDest; }
        }

        /// <summary>
        /// Retourne l'etiquette pour les boîtes fragiles.
        /// </summary>
        public Etiquette EtiquetteFragile
        {
            get { return _etiquetteFragile; }
        }

        #endregion

        #region Constructeurs
        public Boite()
        {
            _hauteur = 30;
            _largeur = 30;
            _longueur = 30;
            Matiere = matieres.carton;
            Articles = new List<Article>();
            _compteurBoite++;
        }

        public Boite(double hauteur, double largeur, double longueur) :this()
        {
            _hauteur = hauteur;
            _largeur = largeur;
            _longueur = longueur;
        }

        public Boite(double hauteur, double largeur, double longueur, matieres matiere) :this(hauteur, largeur, longueur)
        {
            Matiere = matiere;
        }
        #endregion

        #region methodes publiques
        /// <summary>
        /// Ajoute une etiquette destinataire.
        /// </summary>
        /// <param name="destinataire">destinataire de la boite</param>
        public void Etiqueter(string destinataire)
        {
            _etiquetteDest = new Etiquette() {Couleur = couleurs.blanc, Format = formats.L, Texte = destinataire };
        }

        /// <summary>
        /// Ajoute une etiquette destinataire et fragile à la boite.
        /// </summary>
        /// <param name="destinataire">le destinataire de la boite</param>
        /// <param name="fragile">true si la boite est fragile</param>
        public void Etiqueter(string destinataire, bool fragile)
        {
            Etiqueter(destinataire);
            _etiquetteFragile = new Etiquette() { Texte = "FRAGILE" };
        }

        /// <summary>
        /// Ajoute une etiquette destinataire et fragile à la boite.
        /// </summary>
        /// <param name="destinataire">etiquette destinataire</param>
        /// <param name="fragile">etiquette fragile</param>
        public void Etiqueter(Etiquette etqDestinataire, Etiquette etqFragile)
        {
            _etiquetteDest = etqDestinataire;
            _etiquetteFragile = etqFragile;
        }
        /// <summary>
        /// Compare les dimensions et la matière de deux boîtes.
        /// </summary>
        /// <param name="autreBoite">Le nom de la boite à comparer</param>
        /// <returns></returns>
        public bool Compare(Boite autreBoite)
        {
                return _largeur == autreBoite._largeur &&
                _longueur == autreBoite._longueur &&
                _hauteur == autreBoite._hauteur &&
                Matiere == autreBoite.Matiere;
        }
        #endregion
    }
}