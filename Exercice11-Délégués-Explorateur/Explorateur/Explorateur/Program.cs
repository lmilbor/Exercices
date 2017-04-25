using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorateurFichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool analyse = true;

            while (analyse)
            {
                bool nomDossierCorrect = false;
                Console.WriteLine("Saisissez le chemin du dossier à explorer :");
                while (!nomDossierCorrect)
                {
                    try
                    {
                        Analyseur.AnalyserDossier(Console.ReadLine());
                        nomDossierCorrect = true;
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                Console.WriteLine("\n{0} fichiers, dont {1} fichiers .cs\nNom de fichier le plus long :\n{2}\n\nFichiers projets C# :", Analyseur.NombreFichiers, Analyseur.NombreFichiersCs, Analyseur.NomFichierPlusGrand);
                foreach (var fichiers in Analyseur.NomFichiers)
                    Console.WriteLine(fichiers);
                Console.ReadKey();
                Console.WriteLine("Souhaitez-vous continuer l'analyse de dossier ? (oui / non)");
                if (Console.ReadLine() == "non")
                    analyse = false;
                Console.Clear();
            }
        }
    }
}
