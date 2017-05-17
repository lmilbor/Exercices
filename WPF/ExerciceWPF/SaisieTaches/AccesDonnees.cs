using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SaisieTaches
{
    static public class AccesDonnees
    {
        static public List<Tache> ChargerTaches()
        {
            var taches = new List<Tache>();
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Tache>),
      new XmlRootAttribute("Taches"));

            using (var sr = new StreamReader(@"..\..\Taches.xml"))
            {
                // Deserialize renvoie un type object, qu'il faut transtyper 
                taches = (List<Tache>)deserializer.Deserialize(sr);
            }

            return taches;
        }
    }
}
