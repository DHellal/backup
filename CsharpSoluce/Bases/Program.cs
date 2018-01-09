using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases
{


    /// <summary>
    /// Clmasse principal ( documentation technique) 
    /// </summary>
    class Program
    {


        /// <summary>
        /// Ptrogramme principal ( si on fait ça , on pourra tout regrouper apres) peu utilisée
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            /*
                sdf
            */

            int i = 1;
            int j = 5;

            int resulat = Mathelmatiques.Addition(4, 3);        // appelle a la methode static dans l'autre fichier

            int resu = Mathelmatiques.Additionplus(ref i, j);        // ref ça dit : l'adresse de 

            int resultatspe = 0;

            Mathelmatiques.Additionspe(i, j, out resultatspe);


            int produit = Mathelmatiques.Multipli(3, 5, 4, 6, 8, 9, 10);        // marche grace au tableau




            /*

                     try         // tout s'execute doucement et verifie ; donc a eviter car ralentit
                     {

                     }
                     catch (DivideByZeroException z)       // ça c'est si ça à planté on fait quoi ??      // une exception est une classe, dans l'objet exception e on trouve le msg erreur
                     {

                         throw;
                     }     


                     catch         (Exception e)       
                     {


                     }
                     finally     // s'execute dans tout les cas, à la fin du try
                     {



                     }



                     i = 1;
                     j = 2;

                     j = ++i; // ça fait i++ puis i =j , donc les deux dont = a 2
                     j = i++; // ça incremente pas j (a voir ..)




                     switch (i)
                     {


                         case 1:
                         case 2:
                             break;          // icic on dit si =1 et si =2




                     }


                     for (int s = 0, t = 0; s < 100; s++, t++) ;      // possible mettre plusieur variable , on note que s++ se fait à la fin de la boulce !!




                     throw new Exception(" C'est un plantage volontaire!");      // pour se rappeler qu'on doir revenir dessus

                 }*/
        }
    }
}
