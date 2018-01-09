﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyageur
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ville> listeVilles = new List<Ville> {
                new Ville {Nom = "Paris", Gps=Gps("Paris") },
                new Ville {Nom = "Lyon", Gps=Gps("Lyon") },
                new Ville {Nom = "Marseille", Gps=Gps("Marseille") },
                new Ville {Nom = "Bordeaux", Gps=Gps("Bordeaux") },
                new Ville {Nom = "Strasbourg", Gps=Gps("Strasbourg") }
            };
            ListParcours TousLesParcours = new ListParcours(listeVilles);

            var resultat = TousLesParcours;
            
         //       .Where(p => p.Distance == TousLesParcours.Min(p2 => p2.Distance));
            foreach(Parcours p in resultat)
            {
                Console.WriteLine(p);
            }

            Console.Read();
        }

        public static double[] Gps(string ville)
        {
            switch (ville.ToUpper())
            {
                case "PARIS": return new double[] { 2.3522219000000177, 48.85661400000001 };
                case "LYON": return new double[] { 4.835658999999964, 45.764043 };
                case "MARSEILLE": return new double[] { 5.369779999999992, 43.296482 };
                case "BORDEAUX": return new double[] { -0.5791799999999512, 44.837789 };
                case "STRASBOURG": return new double[] { 7.752111300000024, 48.57340529999999 };
            }
            return null;
        }
    }
    class Ville
    {
        public string Nom;
        public double[] Gps = new double[2];
    }
    class Parcours : List<Ville>
    {
        public double Distance
        {
            get
            {
                double distanceTotale = 0;
                for(int i=0; i < this.Count-1; i++)
                {
                    Ville v1 = this[i];
                    Ville v2 = this[i+1];
                    distanceTotale += CalculDistance(v1.Gps[0], v1.Gps[1], v2.Gps[0], v2.Gps[1]);
                }
                return distanceTotale;
            }
        }
        private double CalculDistance(double longA, double latA, double longB, double latB)
        {
            double a = latA * Math.PI / 180;
            double b = latB * Math.PI / 180;
            double c = longA * Math.PI / 180;
            double d = longB * Math.PI / 180;
            return 6367.445 * Math.Acos(Math.Sin(a) * Math.Sin(b) + Math.Cos(a) * Math.Cos(b) * Math.Cos(c - d));
        }

        //internal void Combine(List<Ville> villes)
        //{
        //    Add(villes[0]);
        //    if (villes.Count != 1)
        //    {
        //        List<Ville> villesRestantes = new List<Ville>();
        //        for (int i = 1; i < villes.Count; i++)
        //        {
        //            villesRestantes.Add(villes[i]);
        //        }
        //        Combine(villesRestantes);
        //    }
        //}
        public override string ToString()
        {
            string ligne = "";
            foreach(Ville v in this)
            {
                ligne += v.Nom + " - ";
            }
            return ligne;
        }
    }
    class ListParcours : List<Parcours>
    {
        private List<Ville> ListeInitiale = null;
        public ListParcours(List<Ville> villes)
        {
            ListeInitiale = villes;
            Combine(new Parcours());
        }

        private void Combine(Parcours villes)
        {
            var villesRestantes = ListeInitiale.Except(villes).ToList();        // 1. prends ville 0 et la mets de coté

            if (villesRestantes.Count == 0)             // 3. jusqu'a ne plus avoir de villerestante
            {
                villes.Add(ListeInitiale[0]);
                Add(villes);
            }
            else if (villes.Count == 0)             // ~ si on est au debut on mets paris et on lance combine
            {
                villes.Add(ListeInitiale[0]);
                Combine(villes);
            }
            else
            {
                foreach(var v in villesRestantes)               // 2. pour chaque ville restante, on creer un parcours (permutation possible car a chaque foreach, on passe à la ville suivante qu'on mets au debut) 
                {
                    var nouvellesVilles = new Parcours();
                    nouvellesVilles.AddRange(villes);
                    nouvellesVilles.Add(v);
                    Combine(nouvellesVilles);
                }
            }
        }
    }
}
