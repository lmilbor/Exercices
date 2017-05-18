using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Collection_BD
{

    // Classe nécessaire pour que l'élément xml soit bien nommé <Auteur>
    // Si on utilisait une List<string>, l'élément xml serait nommé <string>
    public class Auteur
    {
        // XMLText désigne le texte à l'intérieur d'un élément
        [XmlText]
        public string Nom { get; set; }
    }
}
