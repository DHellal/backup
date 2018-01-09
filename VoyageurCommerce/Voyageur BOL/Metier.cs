using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Voyageur_BOL
{
    public class Ville
    {
        public string Nom;
        public double[] Gps = new double[2];
    }
    public class Parcours : List<Ville>
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

    public class ListParcours : List<Parcours>
    {
        private List<Ville> ListeInitiale = null;
        public ListParcours(List<Ville> villes)
        {
            ListeInitiale = villes;
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


}
