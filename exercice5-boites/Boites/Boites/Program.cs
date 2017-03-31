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
            Boite boite1 = new Boite(30, 40, 50, matieres.plastique);
            /*
            /// Création de boites et d'étiquettes.
            Boite boite2 = new Boite(30, 60, 20, matieres.carton);

            Etiquette etiquetteDest = new Etiquette { Couleur = couleurs.blanc, Format = formats.L, Texte = "John John" };
            Etiquette etiquetteFragile = new Etiquette { Couleur = couleurs.rouge, Format = formats.S, Texte = "FRAGILE" };
            Etiquette etq = new Etiquette { Couleur = couleurs.bleu, Texte = "Un texte.", Format = formats.M };

            boite1.Etiqueter(etiquetteDest, etiquetteFragile);
            boite2.Etiqueter("John F.", true);


            /// Test de la methode compare.
            Console.Write("Les deux boites ont-elles les même dimensions et matières ? ");
            if (boite1.Compare(boite2))
                Console.WriteLine("vrai");
            else
                Console.WriteLine("faux");

            /// Test du compteur de boite (avec un static) et des Etiquettes.
            Console.WriteLine("Nombre de boîtes crées : " + Boite.CompteurBoite);
            Console.WriteLine("Etiquette de la boite 1 : {0} {1}", boite1.EtiquetteDest.Texte, boite1.EtiquetteFragile.Texte);
            Console.WriteLine("Etiquette de la boite 2 : {0} {1}", boite2.EtiquetteDest.Texte, boite2.EtiquetteFragile.Texte);
            */

            //// Test sur les liste avec Article
            var a1 = new Article(1, "Article 1", 540);
            var a2 = new Article(2, "Article 2", 200);
            var a3 = new Article(1, "Article 3", 600);

            /// Attention, la methode Add ajoute des objet par défaut d'ou le transtypage pour modifier le Libellé.
            boite1.Articles.Add(a1);
            boite1.Articles.Add(a2);
            boite1.Articles.Add(a3);

            /// Appel de la fonction ToString par defaut de Console.WriteLine.
            for (int i=0; i<boite1.Articles.Count; i++)
            {
                //Console.WriteLine(boite1.Articles[i]);
                if (boite1.Articles[i] is Article)
                    ((Article)boite1.Articles[i]).Libellé = "qoeztgi";
                else
                    throw new ArgumentException();
            }



            /// On peut utiliser for each parce que ArrayList utilise l'interface IEnumerable.
            foreach (var a in boite1.Articles)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}
