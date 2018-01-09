using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyageur_BOL;
using Voyageur_DAL;

namespace Voyageur
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Ville> listeVilles = new List<Ville> {
                new Ville {Nom = "Paris", Gps=Donnees.Gps("Paris") },
                new Ville {Nom = "Lyon", Gps=Gps("Lyon") },
                new Ville {Nom = "Marseille", Gps=Gps("Marseille") },
                new Ville {Nom = "Bordeaux", Gps=Gps("Bordeaux") },
                new Ville {Nom = "Strasbourg", Gps=Gps("Strasbourg") }
            };
            ListParcours TousLesParcours = new ListParcours(listeVilles);

            var resultat = TousLesParcours
                .Where(p => p.Distance == TousLesParcours.Min(p2 => p2.Distance));
            foreach(Parcours p in resultat)
            {
                Console.WriteLine(p);
            }

            Console.Read();
        }

       
    }


    
}
