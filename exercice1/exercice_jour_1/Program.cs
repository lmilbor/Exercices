using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_jour_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CombienNombrePremier();
            Console.ReadKey();
        }

        static void PGCD()
        {
            int pgcd = 1;
            int P, Q;
            int p, q;
            string charP, charQ;
            Console.WriteLine("Entrez le premier nombre : ");
            charP = Console.ReadLine();
            Console.WriteLine("\nEntrez le second nombre : ");
            charQ = Console.ReadLine();
            P = int.Parse(charP);
            Q = int.Parse(charQ);
            p = P;
            q = Q;
            while (p != q)
            {
                if (p > q)
                {
                    p -= q;
                }
                else
                {
                    q -= p;
                }
                pgcd = p;
            }
            Console.WriteLine("Le PGCD de " + P + " et " + Q + " est : " + pgcd);
        }

        static bool EstPremier(int nombre)
        {
            int  diviseur;
            bool estPremier = true;
            
            diviseur = 2;
            if (nombre%diviseur == 0)
            {
                estPremier = false;
            }
            diviseur = 3;
            while (diviseur < nombre/2 && estPremier == true)
            {
                if (nombre%diviseur == 0)
                {
                    estPremier = false;
                }
                else
                {
                    diviseur += 2;
                }
            }

            return estPremier;
        }
        static void CombienNombrePremier()
        {
            int nombre, nbPremier;
            nbPremier = 1;
            Console.WriteLine("Entrez votre nombre (nombre > 2) : ");
            string charNb = Console.ReadLine();
            nombre = int.Parse(charNb);

            for (int i=3; i<=nombre; i += 2)
                {
                    if (EstPremier(i) == true)
                    {
                        nbPremier++;
                    }
                }
            Console.WriteLine("Il y a : " + nbPremier + " nombres premier jusque " + nombre);
        }

        static void QuelNombrePremier()
        {
            Console.WriteLine("Entrez votre nombre (nombre > 2) : ");
            string charNb = Console.ReadLine();
            int nombre = int.Parse(charNb);

        }

    }
}
