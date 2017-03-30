using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statuts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personne> taf = new List<Personne>
            {
                new Personne("TURPIN", "Abel", Statuts.CDI),
                new Personne("BONNEAU", "Achille", Statuts.CDD | Statuts.DP),
                new Personne("BLONDEL", "Adelphe",Statuts.CDI | Statuts.DP | Statuts.CHSCT | Statuts.SYND),
                new Personne("BLACK", "Aimé", Statuts.CDI),
                new Personne("PERRIER", "Aimée", Statuts.CDI),
                new Personne("JORDAN", "Alain", Statuts.CDD | Statuts.CHSCT),
                new Personne("BAUDRY", "Alban", Statuts.CDD),
                new Personne("ORLEANS", "Albert", Statuts.CDI | Statuts.DP | Statuts.SYND),
                new Personne("VALOIS", "Alexandra", Statuts.CDI | Statuts.SYND),
                new Personne("WEST", "Alexandre", Statuts.CDI | Statuts.DP | Statuts.CHSCT)
            };
            List<Personne> cddChsct = new List<Personne>();
            List<Personne> cdiDp = new List<Personne>();
            Statuts masqueCDDunionCHSCT = Statuts.CDI | Statuts.CHSCT;
            Statuts masqueCDIunionDP = Statuts.CDI | Statuts.CDI;
            foreach (Personne p in taf)
            {
                if ((p.Statut & masqueCDDunionCHSCT) == masqueCDDunionCHSCT)
                    cddChsct.Add(p);
                if ((p.Statut & masqueCDIunionDP) == masqueCDIunionDP)
                    cdiDp.Add(p);
            }
            foreach (Personne p in cdiDp)
            {
                Console.WriteLine(p.ToString());
                //p.Statut |= Statuts.CHSCT;
            }

            //taf[0].Statut &= ~Statuts.CDI;
            //Console.WriteLine(taf[0].ToString());

            Console.ReadKey();
        }
    }
}
