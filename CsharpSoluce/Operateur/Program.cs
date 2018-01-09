using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operateur         // voir son truc !!
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 12;
            int b = 45;
            int c = a + b;
            c = Plus(a, b);

            Boite b1 = new Boite { Hauteur = 1, largeur = 2, Longeur = 3 };

            Boite b2 = b1 * 2;      // boite * entier existe pas




        }
        static int Plus(int i, int j) { return i + j; }



    }
}
