using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1du12dec
{
    public class Program1
    {
        public static void Main(string[] args)
        {

            List<piece> Lpieces = new List<piece>        // on deciode que la premiere piece dans la lsite est la plus grande
            {

                new piece { Nom ="piece2€", taille = 3 },
                new piece { Nom = "piece1€", taille = 2 },
                new piece { Nom = "piece50c", taille = 1 },
            };




        

            


            List<Emplacement> places = new List<Emplacement>
            {

                new Emplacement {Nom ="A" },
                new Emplacement { Nom = "B" },
                new Emplacement { Nom = "C" },


            };


            places[0].ListesurPieces = Lpieces;




            jeu j = new jeu();
            j.SeDeplace(Lpieces, places[0], places[1], places[2]);           // deplace pile de a vers b avec c comme intermediaire

            //List<piece> Listefinale = new List<piece>();
            //Listefinale = SeDeplace(places[0].ListesurPieces, places[0], places[1], places[2] );












        }
    }
}







