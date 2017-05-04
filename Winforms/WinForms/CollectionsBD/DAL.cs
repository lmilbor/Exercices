using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionsBD
{
    static public class DAL
    {
        /// <summary>
        /// Retourne une liste avec les titre des albums sortis dans la plage d'années indiquée
        /// </summary>
        /// <param name="annéeDébut"></param>
        /// <param name="annéeFin"></param>
        /// <returns></returns>
        static public List<string> ListeTitreAlbum(int annéeDébut, int annéeFin)
        {
            List<string> listeTitreAlbums = new List<string>();
            // Chargement du fichier xml 
            XDocument doc = XDocument.Load(@"C:\Users\lmilbor\OneDrive\Documents\Support de cours\Exercices\WinForms\CollectionsBD.xml");

            // Récupération de tous les titres d'albums dont l'année est compris entre annéeDébut et annéeFin
            listeTitreAlbums = doc.Descendants("Album").
                Where(a => int.Parse(a.Attribute("Année").Value) > annéeDébut && int.Parse(a.Attribute("Année").Value) < annéeFin).
                Select(t => t.Attribute("Titre").Value).ToList();

            return listeTitreAlbums;
        }
        /// <summary>
        /// Ajoute un auteur à la collection de BD donnée.
        /// </summary>
        /// <param name="auteur"></param>
        /// <param name="collection"></param>
        static public void AjoutAuteur(string auteur, CollectionBD collection)
        {

        }

        static public void AjoutAlbum(CollectionBD collection)
        {

        }

        static public void SetToUpper(string titre)
        {

        }

        #region Méthode en dur

        static public void AjoutPascalLuckyLuke()
        {
            // Chargement du fichier xml 
            XDocument doc = XDocument.Load(@"C:\Users\lmilbor\OneDrive\Documents\Support de cours\Exercices\WinForms\CollectionsBD.xml");

            // Récupération des auteurs de la collection luky luke
            var al = doc.Descendants("CollectionBD").Where(a => a.Attribute("Nom").Value == "Lucky Luke").Descendants("Auteurs").FirstOrDefault();

            //...puis ajout de l'auteur
            al.Add(new XElement("Auteur", "Pascal Dabère"));

            //... et enregistrement du fichier
            doc.Save(@"C:\Users\lmilbor\OneDrive\Documents\Support de cours\Exercices\WinForms\CollectionsBD.xml");
        }

        static public void AjoutAlbumLuckyLuke()
        {
            // Chargement du fichier xml 
            XDocument doc = XDocument.Load(@"C:\Users\lmilbor\OneDrive\Documents\Support de cours\Exercices\WinForms\CollectionsBD.xml");

            // Récupération des auteurs de la collection luky luke
            var al = doc.Descendants("CollectionBD").
                Where(a => a.Attribute("Nom").Value == "Lucky Luke");

            //...puis ajout de l'auteur
            Album album = new Album();
            album.Titre = "Le pont sur le Mississippi";
            album.Année = 1994;
            album.Id = al.Descendants("Album").Attributes("Id").Max( a => (int)a) + 1;
            var collAlbum = al.Descendants("Albums").FirstOrDefault();

            collAlbum.Add(new XElement("Album", new XAttribute("Id", album.Id), new XAttribute("Titre", album.Titre), new XAttribute("Année", album.Année)));

            //... et enregistrement du fichier
            doc.Save(@"C:\Users\lmilbor\OneDrive\Documents\Support de cours\Exercices\WinForms\CollectionsBD.xml");
        }

        static public void SetToUpperAsterix()
        {
            // Chargement du fichier xml 
            XDocument doc = XDocument.Load(@"C:\Users\lmilbor\OneDrive\Documents\Support de cours\Exercices\WinForms\CollectionsBD.xml");

            // Récupération des auteurs de la collection luky luke
            var titre = doc.Descendants("CollectionBD").
                Where(a => a.Attribute("Nom").Value == "Astérix").Descendants("Album").
                Where( a => int.Parse(a.Attribute("Id").Value) == 15).Select( a => a.Attribute("Titre")).FirstOrDefault();

            //...puis ajout de l'auteur
            titre.Value = titre.Value.ToUpper();

            //... et enregistrement du fichier
            doc.Save(@"C:\Users\lmilbor\OneDrive\Documents\Support de cours\Exercices\WinForms\CollectionsBD.xml");

        }

        #endregion
    }
}
