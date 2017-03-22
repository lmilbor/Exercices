using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrainement
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();
            Console.ReadKey();
        }
        static void Demo()
        {
            string texte;
            string phrase;
            int nbPhrase, nbMots, nbCaractères; // plusierus déclaration

            const double PI = 3.1415926; // déclaration de constante
            const string DEB_LISTE = " - ";

            phrase = "Le C# est un langage moderne et puissant !";
            texte = phrase;
            texte = texte + " Il est utilisé pour toute sortes d'applications\n";
            texte = texte + DEB_LISTE + "Application console\n";
            texte += DEB_LISTE + "Application fenêtrée Winforms et WPF\n"; // idem -> texte = texte + ...

            Console.WriteLine(texte);
            char lettre;
            lettre = phrase[3];
            Console.WriteLine(lettre);

            short s = 2;
            s ++; // idem -> s += 1 -> s = s + 1
            Console.WriteLine("La Valeur de s est : " + s);

            int[] tabPos = new int[3] { 3, 4, 40}; // tableau de 3 entiers et on donne les valeurs des cases du tableau.
            // tabPos[0] = 3;
            // tabPos[1] = 3;
            // tabPos[1] = 4;

            Console.WriteLine(tabPos.Length); // affiche la longueur du tableau.
            // char[] tabChars = new char[5];

            for (int i=0; i<tabPos.Length; i++)
            {
                Console.WriteLine(tabPos[i]);
            }

            int j = 0;
            while (j < tabPos.Length)
            {
                Console.WriteLine(tabPos[j]);
                j++;
            }

            Console.Clear(); // vide la console.
            Console.WriteLine(texte);

            nbPhrase = 0;
            for (int i=0; i<texte.Length; i++)
            {
                if (texte[i] == '\n')
                {
                    nbPhrase++;
                }
            }
            Console.WriteLine("Il y a " + nbPhrase + " lignes dans le texte.");

            nbMots = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == ' ' || phrase[i] == '\n' || phrase[i] == '\'')
                {
                    nbMots++;
                }
            }
            Console.WriteLine("Il y a " + nbMots + " mots dans le texte.");

            string valeur = Console.ReadLine(); // On rentre une valeur au clavier qu'on stocke dans valeur.
            int x = int.Parse(valeur); // On interprete la valeur en tant qu'entier -> On transforme une chaine en entier
        }
    }
}
