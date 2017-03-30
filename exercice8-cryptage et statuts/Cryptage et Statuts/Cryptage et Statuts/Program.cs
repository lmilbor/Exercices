using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptage
{
    class Program
    {
        static void Main(string[] args)
        {
            Cryptage.ChargerClef(@"D:\Exercices\exercice8-cryptage et statuts\cle.txt");
            Console.WriteLine(Cryptage.CrypterFichier("Machin à crypter.123"));
            Console.ReadKey();
        }
    }
}
