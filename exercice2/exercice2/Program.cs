using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tableau = { "a", "A", "a", "V", "B"};
            AfficheTableauSurLigne(TriAlphaTableauDecalage(tableau));
            Console.ReadKey();
        }

        static void AfficheTableauSurLigne(string[] tableau)
        {
            for (int element = 0; element < tableau.Length; element++)
            {
                Console.Write(tableau[element] + " ");
            }
        }

        static string[] TriAlphaTableau(string[] tableau)
        {
            string[] tableauTri = tableau;
            bool estPasModifie = false;
            string changeur;
            while (!estPasModifie)
            {
                int compteur = 0;
                estPasModifie = true;
                while (estPasModifie && compteur < tableauTri.Length-1)
                {
                    if (tableauTri[compteur].CompareTo(tableauTri[compteur + 1]) > 0)
                    {
                        changeur = tableauTri[compteur];
                        tableauTri[compteur] = tableauTri[compteur + 1];
                        tableauTri[compteur + 1] = changeur;
                        estPasModifie = false;
                    }
                    compteur++;
                }
            }
            return tableauTri;
        }

        static string[] TriAlphaTableauDecalage(string[] tableau)
        {
            string[] tableauTri = new string[tableau.Length]; // On crée un tableau vide de la taille du tableau à trier
            tableauTri[0] = tableau[0]; // On met le premier élément du tableau à trier
            int reference = 0;
            int save = 0;
            bool estPlace = false;
            for (int element = 1; element < tableau.Length; element++)
            {
                reference = save;
                estPlace = false;
                while (!estPlace)
                {
                    if (tableauTri[reference].CompareTo(tableau[element]) <= 0)
                    {
                        DecaleADroite(tableauTri, reference);
                        tableauTri[reference + 1] = tableau[element];
                        estPlace = true;
                    }
                    else
                    {
                        reference--;
                    }
                }
                save++;
            }
            return tableauTri;
        }

        static void DecaleADroite(string[] tableau, int rangFin) //rangFin = jusque ou faut il remonter le tableau.
        {
            int rangDepart = tableau.Length - 1;
            for (int element = rangDepart; element >= rangFin + 1; element--)
            {
                tableau[element] = tableau[element - 1];
            }
        }
    }
}
