using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyageur.DAL;

namespace Voyageur.BOL
{
    public static class Metier
    {
        public static string ParcoursLePlusCourt(List<string> villesChoisies)
        {
            ListParcours TousLesParcours = new ListParcours(villesChoisies);
            var resultat = TousLesParcours
                .Where(p => p.Distance == TousLesParcours.Min(p2 => p2.Distance))
                .FirstOrDefault();
            return resultat.ToString();
        }
    }
    class ListParcours : List<Parcours>
    {
        private List<Ville> ListeInitiale = new List<Ville>();

        public ListParcours(List<string> villesChoisies)
        {
            foreach (string v in villesChoisies)
            {
                ListeInitiale.Add(new Ville { Nom = v, Gps = Donnees.GetGps(v) });
            }
            Combine(new Parcours());
        }

        private void Combine(Parcours villes)
        {
            var villesRestantes = ListeInitiale.Except(villes).ToList();
            if (villesRestantes.Count == 0)
            {
                villes.Add(ListeInitiale[0]);
                Add(villes);
            }
            else if (villes.Count == 0)
            {
                villes.Add(ListeInitiale[0]);
                Combine(villes);
            }
            else
            {
                foreach (var v in villesRestantes)
                {
                    var nouvellesVilles = new Parcours();
                    nouvellesVilles.AddRange(villes);
                    nouvellesVilles.Add(v);
                    Combine(nouvellesVilles);
                }
            }
        }
    }
    public class Parcours : List<Ville>
    {
        public double Distance
        {
            get
            {
                double distanceTotale = 0;
                for (int i = 0; i < this.Count - 1; i++)
                {
                    Ville v1 = this[i];
                    Ville v2 = this[i + 1];
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
        public override string ToString()
        {
            string ligne = "";
            foreach (Ville v in this)
            {
                ligne += v.Nom + " - ";
            }
            return ligne;
        }
    }
    public class Ville
    {
        public string Nom;
        public double[] Gps = new double[2]; // Longitude, Latitude
    }
}