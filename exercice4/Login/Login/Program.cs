using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, mdp;
            bool loginCorrect = false;
            bool mdpCorrect = false;

            while (!loginCorrect)
            {
                try
                {
                    Console.WriteLine("Entrez votre login :");
                    login = Console.ReadLine();
                    VerificationLogin(login);
                    loginCorrect = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (!mdpCorrect)
            {
                try
                {
                    Console.WriteLine("Entrez votre mot de passe :");
                    mdp = Console.ReadLine();
                    VerificationMdp(mdp);
                    mdpCorrect = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Votre compte a bien été créé. Un message vient de vous être envoyé.");
            Console.ReadKey();
        }

        static bool VerificationLogin(string login)
        {
            bool loginCorrect = true;
            if (login.Length < 5)
            {
                loginCorrect = false;
                throw new FormatException("Votre login doit contenir au moins 5 caractères.");
            }
            return loginCorrect;
        }

        static bool VerificationMdp(string mdp)
        {
            bool mdpCorrect = true;
            if (mdp.Length < 6 || mdp.Length > 12)
            {
                mdpCorrect = false;
                throw new FormatException("Votre mot de passe doit contenir entre 6 et 12 caractères.");
            }
            if (mdp[0] == ' ' || mdp[mdp.Length-1] == ' ')
            {
                mdpCorrect = false;
                throw new FormatException("Votre mot de passe ne doit pas commencer ou finir par une espace.");
            }
            return mdpCorrect;
        }
    }
}
