﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevésMétéo
{
    class Program
    {
        static void Main(string[] args)
        {
            AnalyseurLINQ meteo = new AnalyseurLINQ();
            meteo.ChargerDonnées();
            meteo.AfficherStats();
            Console.ReadKey();
        }
    }
}
