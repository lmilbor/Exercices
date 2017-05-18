using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Collection_BD
{
    public static class BD_DAL
    {
        // Charge la liste de collections à partir du fichier xml
        public static List<CollectionBD> ChargerCollectionsBD()
        {
            List<CollectionBD> listCol = null;

            XmlSerializer deserializer = new XmlSerializer(typeof(List<CollectionBD>),
                new XmlRootAttribute("CollectionsBD"));
            using (var sr = new StreamReader(@"..\..\CollectionsBD.xml"))
            {
                // Deserialize renvoie un type object, qu'il faut transtyper 
                listCol = (List<CollectionBD>)deserializer.Deserialize(sr);
            }

            return listCol;
        }
    }
}
