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
            Etiquette etiquetteDest = new Etiquette { Couleur = couleurs.blanc, Format = formats.L, Texte = "John John" };
            Etiquette etiquetteFragile = new Etiquette { Couleur = couleurs.rouge, Format = formats.S, Texte = "FRAGILE" };
            boite1.Etiqueter(etiquetteDest, etiquetteFragile);
            //Boite boite2 = new Boite(30, 60, 20, matieres.carton);
            //boite2.Etiqueter("John F.", true);
            //Etiquette etq = new Etiquette { Couleur = couleurs.bleu, Texte = "Un texte.", Format = formats.M };
            //Console.Write("Les deux boites ont-elles les même dimensions et matières ? ");
            //if (boite1.Compare(boite2))
            //    Console.WriteLine("vrai");
            //else
            //    Console.WriteLine("faux");
            //Console.WriteLine("Nombre de boîtes crées : " + Boite.CompteurBoite);
            Console.WriteLine("Etiquette de la boite 1 : {0} {1}", boite1.EtiquetteDest.Texte, boite1.EtiquetteFragile.Texte);
            //Console.WriteLine("Etiquette de la boite 2 : {0} {1}", boite2.EtiquetteDest.Texte, boite2.EtiquetteFragile.Texte);
            Console.ReadKey();
        }
    }
}
