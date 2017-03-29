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
            Vehicule r5 = new Voiture("zef", energies.Essence);
            Vehicule honda = new Moto("CBF600", energies.Essence);
            Console.WriteLine(r5.Description);
            Console.WriteLine("La {0} coute " + r5.PRK() + " euros par kilomètres.", r5.Nom);
            Console.WriteLine(honda.Description);
            Console.WriteLine("La {0} coute " + honda.PRK() + " euros par kilomètres.", honda.Nom);
            Console.ReadKey();
        }
    }
}
