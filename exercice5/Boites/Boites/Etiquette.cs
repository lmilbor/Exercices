using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boites
{
    /// <summary>
    /// Définit un type de formlat : XS, S, M, L, XL.
    /// </summary>
    public enum formats
    {
        XS, S, M, L, XL
    }
    public class Etiquette
    {
        public string Texte { get; set; }
        public couleurs Couleur { get; set; }
        public formats Format { get; set; }
    }
}
