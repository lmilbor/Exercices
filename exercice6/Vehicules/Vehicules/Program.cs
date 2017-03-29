using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicules
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicule r5 = new Voiture("zef", energies.Essence);
            //Vehicule honda = new Moto("CBF600", energies.Essence);
            Vehicule[] tableauVehicules =
            {
                new Voiture("zef", energies.Essence),
                new Moto("CBF600", energies.Essence),
                new Moto("Scout",energies.Essence),
                new Voiture("Tesla", energies.Electrique)
            };

            for (int i=0; i<tableauVehicules.Length; i++)
            {
                if (tableauVehicules[i] is Voiture)
                    Console.WriteLine("{0} sur la {1}", ((Voiture)tableauVehicules[i]).RefaireParallélisme(), tableauVehicules[i].Nom);
            }

            //int comparateur = honda.CompareTo(r5);
            //if (comparateur < 0)
            //    Console.WriteLine("la {0} est plus economique que la {1}.", r5.Nom, honda.Nom);
            //else if (comparateur > 0)
            //    Console.WriteLine("la {0} est plus economique que la {1}.", honda.Nom, r5.Nom);
            //else
            //    Console.WriteLine("Les deux véhicules ont le même PRK.");

            //Console.WriteLine(r5.Description);
            //Console.WriteLine("La {0} coute " + r5.PRK + " euros par kilomètres.", r5.Nom);
            //Console.WriteLine(honda.Description);
            //Console.WriteLine("La {0} coute " + honda.PRK + " euros par kilomètres.", honda.Nom);
            Console.ReadKey();
        }
    }
}
