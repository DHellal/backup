using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NJeu;
using NStatut;


namespace Chifoumi
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Bonjour! \nBienvenue dans Chifoumi!\n");

            joueur ko;
            ko = new joueur();          // on declare et instancie en meme temps


            joueur Humain = new joueur { Esthumain = true };
            joueur Machine = new joueur();
            Jeu partie = new Jeu();
            int check = 0;

            for (int i = 0; i < 100; i++)           // On peut aussi mettre :   while (!humain.AGagne() && ! machine.AGagne())       dans ce cas utiliser les machine .point pour incrementations et tout
            {

                var choixhuman = Humain.Choisir();
                var choixmachie = Machine.Choisir();



                var resulat = partie.compare(choixmachie, choixhuman);



                Console.WriteLine("Ah, moi j'ai chosis : {0} ", Machine.Choisir());






                switch (resulat)
                {

                    case ResultatEnum.Egalite: Console.WriteLine("Nul!"); break;
                    case ResultatEnum.Perdu: Console.WriteLine("Perdu !"); check = 0; break;
                    case ResultatEnum.Gagne: check++; Console.WriteLine("Bravo! Tu as gagné " + check + " fois de suite !"); break;



                }



                if (check == 4) { i = 100; }


            }

            Console.WriteLine(partie.resultatpartie(Machine.points, Humain.points)); // a finir
            Console.Read();
        }





    }












}
