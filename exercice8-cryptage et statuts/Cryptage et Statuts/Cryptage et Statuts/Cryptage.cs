using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptage
{
    static public class Cryptage
    {
        #region Propriétés
        static public Dictionary<char, char> CleCryptage { get; set; }
        #endregion

        #region Constructeur
        static Cryptage()
        {
            CleCryptage = new Dictionary<char, char>();
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Charge un fichier texte avec les clés de cryptage et les stock dans Dictionary CleCryptage.
        /// </summary>
        /// <param name="chemin">Le chemin du fichier texte</param>
        static public void ChargerClef(string chemin)
        {
            string[] fichier = File.ReadAllLines(chemin);
            for (int i=0; i<fichier.Length; i++)
            {
                CleCryptage.Add(fichier[i][0],fichier[i][2]);
            }
        }
        /// <summary>
        /// Charge un fichier texte et utilise Dictionary CleCryptage pour le crypter.
        /// </summary>
        /// <param name="texte">Le chemin du fichier texte</param>
        static public char[] CrypterFichier(string texte)
        {
            //char[] fichier = File.ReadAllText(texte).ToCharArray();
            char[] fichier = texte.ToLower().ToCharArray();
            char temp;
            for (int c=0; c<fichier.Length; c++)
            {
                if (CleCryptage.TryGetValue(fichier[c], out temp))
                    fichier[c] = temp;
            }
            return fichier;
        }
        /// <summary>
        /// Charge un fichier et le décrypte avec Dictionary CleCryptage.
        /// </summary>
        /// <param name="chemin">Le chemin du fichier texte</param>
        static public void Décrypter(string chemin)
        {

        }
        #endregion
    }
}
