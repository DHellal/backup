using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC
{
    class Program
    {
        static void Main(string[] args)
        {



            for (int i=0; i<int.MaxValue; i++)
            {
                //            Livre livre1 = new Livre();     // ici le livre va etre enlevé à la fin de la parenthese et recrée a chaque fois... ça comble la memoire! donc faut demander àGC de nettoyer les anciens livres
                //  GC.Collect();         fait le menage.. mais prends trop de temps


                using (Livre livre1 = new Livre())  // ici elle enleve juste le livre1 et recherche pas toute la memoire            // mais il faut que livre implemente une interface IDisposible
                {



                }



            }




        }
    }
}
