﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //TesterCompteBancaire();
            //TesterMoyensPaiement();
            TesterDécorateursCompte();

            Console.ReadKey();
        }

        static void TesterCompteBancaire()
        {
            CompteBancaire[] tabComptes = new CompteBancaire[2];
            DateTime dt = new DateTime(2016, 2, 25);
            tabComptes[0] = new CompteBancaire(654654165, dt, 500);
            tabComptes[1] = new CompteBancaire(9898745646);

            tabComptes[1].DécouvertAutorisé = -700;
            tabComptes[1].Créditer(1000);
            Console.WriteLine("Solde courant : {0}", tabComptes[1].SoldeCourant);

            tabComptes[1].Débiter(600);
            Console.WriteLine("Solde courant : {0}", tabComptes[1].SoldeCourant);

            tabComptes[1].Débiter(1000);
            Console.WriteLine("Solde courant : {0}", tabComptes[1].SoldeCourant);

            // Le débit suivant produit une exception car le solde du compte
            // est en-dessous du découvert autorisé
            try
            {
                tabComptes[1].Débiter(100);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Opération impossible car pas assez d'argent sur le compte");
            }

            // Création d'une carte
            //Carte carte = new Carte
            //{
            //    NumCarte = 7539514569871234,
            //    CodeSecret = 1234,
            //    CodeVérif = 951,
            //    DateExpiration = DateTime.Today.AddYears(2)
            //};

            //// Association de cette carte au compte (agrégation)
            //tabComptes[1].AjouterCarte(carte);
        }

        static void TesterDécorateursCompte()
        {
            CompteBancaire cb = new CompteBancaire(156146, DateTime.Today, 200);
            cb.DécouvertAutorisé = -1000;

            Console.WriteLine("Valeur du compte : {0}", cb.ValeurCompte);

            // Crée un compte surveillable, qui encapsuble un compte bancaire ordinaire
            // en lui associant des seuils d'alertes
            Surveillable compteSurveillable = new Surveillable(cb, -500, 1000);
            Console.WriteLine(compteSurveillable.EtatCompte);

            cb.Débiter(1000);
            Console.WriteLine();
            Console.WriteLine("Valeur du compte : {0}", cb.ValeurCompte);
            Console.WriteLine(compteSurveillable.EtatCompte);

            cb.Créditer(3000);
            Console.WriteLine();
            Console.WriteLine("Valeur du compte : {0}", cb.ValeurCompte);
            Console.WriteLine(compteSurveillable.EtatCompte);

            Console.WriteLine();
            Convertible compteConvertible = new Convertible(cb);
            Console.WriteLine("Valeur du compte en Yuan : {0}", compteConvertible.ValeurEnYuans);
        }

        static void TesterMoyensPaiement()
        {
            MoyenPaiment carte = new Carte(101)
            {
                NomTitulaire = "Gabin",
                PrénomTitulaire = "Jean",
                CodeSecret = 9999,
                DateExpiration = new DateTime(2017, 09, 30)
            };

            MoyenPaiment chq = new Chéquier(102)
            {
                NomTitulaire = "Delon",
                PrénomTitulaire = "Alain",
                NumPremierChèque = 102001
            };

            Console.WriteLine(carte.ToString());
            Console.WriteLine(chq.ToString());
            Console.WriteLine();
            DateTime dateRenou = new DateTime(2016, 02, 25);
            carte.Renouveler(dateRenou);
            chq.Renouveler(new DateTime(2016, 05, 21));
            Console.WriteLine(carte.ToString());
            Console.WriteLine(chq.ToString());

            Console.WriteLine();

            //MoyenPaiment[] tabMP = new MoyenPaiment[4];
            //tabMP[0] = new Carte(456);
            //tabMP[1] = new Chéquier(456);
            //tabMP[2] = new Carte(789);
            //tabMP[3] = new Chéquier(789);

            //for (int i = 0; i < tabMP.Length; i++)
            //{
            //    Console.WriteLine(tabMP[i].ToString());
            //    Console.WriteLine(tabMP[i].Payer());
            //}
        }
