using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorateurFichiers
{
    public class Explorateur
    {
        public static void Exploreur(string chemin, DelegueExplorateur action)
        {

            DirectoryInfo repertoire = new DirectoryInfo(chemin);
            if (!repertoire.Exists)
                throw new FileNotFoundException("Le dossier auquel vous souhaitez accéder n'existe pas.\nVeuillez entrer un nom de dossier valide.");
            foreach (var f in repertoire.EnumerateFiles("*", SearchOption.AllDirectories))
            {
                action(f);
            }
        }
    }
    public delegate void DelegueExplorateur(FileInfo fichier);
}
