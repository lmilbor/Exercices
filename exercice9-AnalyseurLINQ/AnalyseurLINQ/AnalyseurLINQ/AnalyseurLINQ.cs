using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevésMétéo
{
    public class AnalyseurLINQ
    {
        private List<DonnéesMois> _data;
        public List<DonnéesMois> Data {
            get { return _data; }
        }

        public AnalyseurLINQ()
        {
            _data = new List<DonnéesMois>();
        }

        public void ChargerDonnées()
        {
            string chemin = @"..\..\DonnéesMétéoParis.txt";

            int cpt = 0;
            using (StreamReader str = new StreamReader(chemin))
            {
                string ligne;
                
                while ((ligne = str.ReadLine()) != null)
                {
                    cpt++;
                    if (cpt == 1) continue; // On n'analyse pas la première ligne car elle contient les en-têtes

                    var tab = ligne.Split('\t');
                    try
                    {
                        var donnéesMois = new DonnéesMois
                        {
                            Mois = DateTime.Parse(tab[0]),
                            TMin = double.Parse(tab[1]),
                            TMax = double.Parse(tab[2]),
                            Précipitations = double.Parse(tab[3]),
                            Ensoleillement = double.Parse(tab[4])
                        };

                        // Ajout des données du mois à la liste
                        Data.Add(donnéesMois);
                    }
                    catch (FormatException)
                    {
                        // On ignore simplement la ligne
                        Console.WriteLine("Erreur de format à la ligne suivante :\r\n{0}", ligne);
                    }
                }
            }
        }

        public void AfficherStats()
        {
            // mois de la température min la plus basse
            var températureMin = Data.Min(t => t.TMin);
            var moisFroid = Data.Where(m => m.TMin == températureMin).First();
            Console.WriteLine("Le {0} il a fait le plus froid avec une température de {1}°C.", moisFroid.Mois.ToShortDateString(), températureMin);

            // Sommes des précipitations de l'année 2016
            var sommePrécipitation = Data.Where( y => y.Mois.Year == 2016).Sum(t => t.Précipitations);
            Console.WriteLine("Il y a eu {0}mm de précipitation au cours de l'année 2016.", sommePrécipitation);

            // Durée d'ensoleillement moyenne du mois de Juillet sur toutes les années
            var duréeEnsoleillementMoyen = Data.Where( m => m.Mois.Month == 07).Average(d => d.Ensoleillement);
            Console.WriteLine("La durée d'ensolleillement moyen était de {0}h sur le mois de juillet de chaque année.", duréeEnsoleillementMoyen);

            // Précipitations moyennes par année
            var année = Data.Select(y => y.Mois.Year).Distinct();
            foreach (var a in année)
            {
                var précipitationMoyenne = Data.Where(y => y.Mois.Year == a).Average(p => p.Précipitations);
                Console.WriteLine("En moyenne il y a eu {0}mm de précipitation l'année {1}.", Math.Round(précipitationMoyenne, 2), a);
            }

        }
    }

    /// <summary>
    /// Classe contenant les données d'un mois de relevé météo
    /// </summary>
    public class DonnéesMois
    {
        public DateTime Mois { get; set; }
        public double TMin { get; set; }
        public double TMax { get; set; }
        public double Précipitations { get; set; }
        public double Ensoleillement { get; set; }
    }
}
