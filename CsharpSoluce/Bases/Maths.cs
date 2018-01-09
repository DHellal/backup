using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases
{
    class Mathelmatiques
    {



        public static int Addition(int x, int y)       // ici on la mets en static pour ne pas avoir a faire une objet mathematique pour utiliser addition
        {

            return x + y;


        }


        public static int Additionplus(ref int x, int y)
        {

            x++;        //incremente y et non j      mais les references x et i pointent pareil donc cest i qui sera changé
            y++;
            return x + y;

        }// prends un pointeur en gros


        public static void Additionspe(int x, int y, out int res)       // prends le res en sortie
        {

            res = x + y;



        }



        public static int Multipli(params int[] liste)        //en gros ça dit que tu prends un tableau d'entier nommé liste
        {

            int resultat = 1;                   // pour commencer par *1
            for(int i =0; i< liste.Length; i++)
            {
                resultat *= liste[i];

            }

            return resultat;
        }


        public static int Factorielle(int n)        // fonction qui se rapelle, se rempile (un peu comme les suites
        {



            if (n == 1) return 1;       // pour sortir de la boucle quand elle s'appelle mais que n = 1
            return n * Factorielle(n - 1);      // on rapelle la meme focntion

        }




        

}
}
