using System;
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
            List<Ville> listeVilles = new List<Ville> {             // fait liste des villes
                new Ville {Nom = "Paris", Gps=Gps("Paris") },       // dans gps on appelle methode gps(ville en entrée) : mets les coordonnées selon nom ville
                new Ville {Nom = "Lyon", Gps=Gps("Lyon") },
                new Ville {Nom = "Marseille", Gps=Gps("Marseille") },
                new Ville {Nom = "Bordeaux", Gps=Gps("Bordeaux") },
                new Ville {Nom = "Strasbourg", Gps=Gps("Strasbourg") }
            };
            ListParcours TousLesParcours = new ListParcours(listeVilles);       // demande listes de parcours

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
        public double Distance(double longA, double latA, double longB, double latB)
        {
            double a = latA * Math.PI / 180;
            double b = latB * Math.PI / 180;
            double c = longA * Math.PI / 180;
            double d = longB * Math.PI / 180;
            return 6367.445 * Math.Acos(Math.Sin(a) * Math.Sin(b) + Math.Cos(a) * Math.Cos(b) * Math.Cos(c - d));
        }
    }
    class Ville     //ville et caracteristuques
    {
        public string Nom;
        public double[] Gps = new double[2];
    }


    class ListParcours : List<Parcours>     // liste de parcours (liste de liste de ville)
    {
        public ListParcours(List<Ville> villes) 
        {
            foreach (Ville v in villes)     // qd on appelle listeparcours, fait un parcours pour chaque ville dans liste ville
            {
                Parcours p = new Parcours();
                p.Ajoute(villes);   
            }

        }
    }


    class Parcours : List<Ville>        
    {
        internal void Ajoute(List<Ville> villes)        // pour ajouter des villes au parcours
        {
            Add(villes[0]);     // on ajoute la premiere ville (la ville eu par la classe precednte)



            if (villes.Count != 1)  // si y'a plus qu'une ville ( donc au debut on fait un parcours pour chaque ville)
            {
                List<Ville> villesRestantes = new List<Ville>();
                for (int i = 1; i < villes.Count; i++)
                {
                    villesRestantes.Add(villes[i]);
                }



                Ajoute(villesRestantes);



            }
        }
    }
    
}
