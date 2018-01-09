using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;             // Pour utiliser thread
using System.Threading.Tasks;

namespace _1amille
{
    class Program
    {
        static void Main(string[] args)
        {

            int Debut = 0;
            int Fin = 0;
            int Vitesse = 0;

            //while(Fin  )

            Console.WriteLine("Bienvenue dans le compteur! \nOn commence par quoi ?\n");

            string saisie = Console.ReadLine();

            int.TryParse(saisie, out Debut);


            Console.WriteLine("Jusqu'a ?\n");

            string saisi = Console.ReadLine();

            int.TryParse(saisi, out Fin);


            Console.WriteLine("A quelle vitesse en milli-secondes?\n");

            string sais = Console.ReadLine();

            int.TryParse(sais, out Vitesse);




            if (Fin > Debut && (Fin != 0 && Vitesse != 0))
            {

                Console.WriteLine("OK !");


             

                for (int i = Debut; i < Fin; i++)
                {
                   

                   #region
                    //switch (X)
                    //{


                    //    case 2 = Console.ForegroundColor = ConsoleColor.Black; break;
                    //    case 1: Console.ForegroundColor = ConsoleColor.Yellow; break;
                    //    
    

                    //}

                    #endregion

                    Console.WriteLine(i);

                    Thread.Sleep(Vitesse);          // en millisec la pause

                }
            }



            else
            {
                Console.Write("Erreur!");
            }




            Console.Read();


















        }
    }
}
