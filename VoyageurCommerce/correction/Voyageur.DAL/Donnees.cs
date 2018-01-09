using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyageur.DAL
{
    public static class Donnees
    {
        public static double[] GetGps(string nomVille)
        {
            switch (nomVille)
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
}
