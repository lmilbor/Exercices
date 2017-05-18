using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Collection_BD
{

    public class CollectionBD
    {
        // Par défaut les propriétés sont sérialisées en éléments xml
        // Pour les sérialiser en attributs, il faut les décorer de [XmlAttribute]
        [XmlAttribute]
        public string Nom { get; set; }
        public List<Auteur> Auteurs { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Album> Albums { get; set; }
    }
}
