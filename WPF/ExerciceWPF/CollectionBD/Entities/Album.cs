using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Collection_BD
{
    // Par défaut les attributs xml sont nommés comme les propriétés de la classe
    // Mais on peut spécifier un autre nom via [XmlAttribute("xxx")]
    public class Album
    {
        [XmlAttribute]
        public int Id { get; set; }
        [XmlAttribute]
        public string Titre { get; set; }
        [XmlAttribute]
        public int Année { get; set; }
    }
}
