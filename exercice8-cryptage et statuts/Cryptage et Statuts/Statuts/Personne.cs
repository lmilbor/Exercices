using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statuts
{
    public class Personne
    {
        #region Propriétés
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public Statuts Statut { get; set; }

        #endregion

        #region Constructeur

        public Personne(string nom, string prénom, Statuts statut)
        {
            Nom = Nom;
            Prénom = prénom;
            Statut = statut;
        }

        #endregion

        #region Méthodes
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Nom, Prénom, Statut);
        }
        #endregion

    }
}
