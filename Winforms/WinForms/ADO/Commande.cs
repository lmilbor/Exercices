using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ADO
{
    public class Commande
    {
        [XmlAttribute]
        public int IDCommande { get; set; }
        [XmlAttribute]
        public string IDClient { get; set; }
        [XmlAttribute]
        public DateTime DateCommande { get; set; }
        public List<LigneCommande> LigneCommande { get; set; }
    }
    public class LigneCommande
    {
        [XmlAttribute]
        public int IDProduit { get; set; }
        [XmlAttribute]
        public decimal PrixUnitaire { get; set; }
        [XmlAttribute]
        public short Quantité { get; set; }
        [XmlAttribute]
        public float Réduction { get; set; }
    }
}
