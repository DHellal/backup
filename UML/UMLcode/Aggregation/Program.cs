using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {

            // classe de type rédference

            Cheval c1; // Declaration
            c1 = new Cheval();  // Construction    
            c1.Nom = "Jolly jumper";  // initialisation
            c1.proprio = "Lucky luke";  // initialisation



            // classe de type valeur

            int i;  // declaration et construction
            i = 7; // initialisation


            Cheval c2; // declare c2
            c2 = new Cheval();
            c2 = c1; // l'objet que pointait c2 est perdu et c1 et c2 pointent vers l'objet du chaval c1
            c2.proprio = "Zorro";

            Cheval c3 = new Cheval { Nom = "loli", proprio = "poto" };


            Console.WriteLine(c1.proprio);
            Console.WriteLine(c2.Nom);
            Console.WriteLine("c3 : {0} est la proprieté de {1}", c3.Nom, c3.proprio );


            Console.Read();



        }
    }

    public class Cheval
    {
        public string Nom;
        public string proprio;
    }
}
