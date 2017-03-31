using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comptage_voyelles_consonnes
{
    class Program
    {
        static void Main(string[] args)
        {
            string mot = "Livre";
            int nbVoyelle, nbConsonne;
            NombreVoyellesConsonnes(mot, out nbVoyelle, out nbConsonne);
            Console.WriteLine("\"{0}\" comprend {1} consonnes et {2} voyelles ", mot, nbConsonne, nbVoyelle);
            Console.ReadKey();
        }
        static bool EstUneVoyelle(char lettre)
        {
            bool estUneVoyelle = false;
            string voyelles = "AEIOUYaeiouy";
            int compteur = 0;
            while (compteur < voyelles.Length && !estUneVoyelle)
            {
                if (lettre == voyelles[compteur])
                    estUneVoyelle = true;
                compteur++;
            }
            return estUneVoyelle;
        }

        static void NombreVoyellesConsonnes(string mot, out int nbVoyelle, out int nbConsonne)
        {
            nbVoyelle = 0;
            mot = mot.ToUpper();
            for (int i=0; i<mot.Length; i++)
            {
                if (EstUneVoyelle(mot[i]))
                    nbVoyelle++;
            }
            nbConsonne = mot.Length - nbVoyelle;
        }
    }
}
