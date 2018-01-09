using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multitache
{
    class Compteur
    {

        public int Min = 1;
        public int Max = 10;
        public int Pas = 1;


        public ConsoleColor Couleur = ConsoleColor.Yellow;

        public int Pause  = 800;

        public void Compte()
        {

            for(int i=Min; i<= Max; i += Pas)
            {

                Console.ForegroundColor = Couleur;
                Console.WriteLine(i);

                Thread.Sleep(Pause);
            }



        }





    }




    delegate void CompteDelegate();     // un delegué qui prends pas de para et retourne void

}
