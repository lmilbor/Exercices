using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorateurFichiers
{
    public class Analyseur
    {
        static public int NombreFichiers { get; set; } // créer un enumerate avec les type de fichiers ?
        static public int NombreFichiersCs { get; set; }
        static public string NomFichierPlusGrand { get; set; }
        static public List<string> NomFichiers { get; set; }
        static public void AnalyserDossier(string chemin)
        {
            NombreFichiers = 0;
            NombreFichiersCs = 0;
            NomFichierPlusGrand = string.Empty;
            NomFichiers = new List<string>();
            DelegueExplorateur explorateur = null;
            explorateur += CompterFichiers;
            explorateur += AnalyserNom;
            explorateur += FiltrerProjet;
            Explorateur.Exploreur(chemin, explorateur);
        }
        static public void CompterFichiers(FileInfo fichier)
        {
            NombreFichiers++;
            if (fichier.Extension == ".cs")
                NombreFichiersCs++;
        }

        static public void AnalyserNom(FileInfo fichier)
        {
            if (fichier.Name.Length > NomFichierPlusGrand.Length)
                NomFichierPlusGrand = fichier.Name;
        }

        static public void FiltrerProjet(FileInfo fichier)
        {
            if (fichier.Extension == ".csproj")
                NomFichiers.Add(fichier.Name);
        }

    }
}
