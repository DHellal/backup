using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N1;           // on dit recherche dans N1

namespace As2
{
    class Class2
    {
    }
}


namespace N2            // on fait un N2
{



    public class Partie
    {

        public int Nombremystere = 0;
        public int NcoupMax = 7;
        public Statut Comparer(Joueur j)            // methode qui renvoie un statut et qui prends le nom d'un joueur j (qu'il faudrat construire au preablable)
        {

            j.Ncoup++;                                  //increùmente le nombre de coup du joueur j
            if (j.Ncoup > NcoupMax) return Statut.Perdu;                // retorune valeur arrete la boucle : pas besoin de else !!

            if (j.Nombrepropose < Nombremystere) return Statut.Troppetit;
            if (j.Nombrepropose > Nombremystere) return Statut.TropGrand;
            return Statut.Gagne;




        }

        public void initialise()
        {
            Random alea = new Random();             // on fait le generateur de nombre aleatoire
            Nombremystere = alea.Next(1, 99);       // on fait un nombrz aleatoire avec la methode next entre 1 et 99

        }
    }



    public class Joueur
    {

        public int Nombrepropose = 0;
        public Statut Resulat = Statut.Nondefini;
        public int Ncoup = 0;



        public void initialisej()           // methode initialise les parametres de joueur au cas ou il recommence une partie
        {

            Ncoup = 0;
            Resulat = Statut.Nondefini;
            Nombrepropose = 0;



        }

        [Obsolete("pas cette methode")]
        public void initialisej1(int n)           // methode comme l'autre mais on va dire qu'elle est obsolete -- > attribut // c'est de l'overload : 2 methode avec meme nom
        {

            Ncoup = 0;
            Resulat = Statut.Nondefini;
            Nombrepropose = 0;



        }

        public void donnenombre(int n)         // methode pour prendre nombre du joueur, on dit que la fonction va recevoir un int qu'on appelera n dans cette methode
        {

            int saisieint = 0;
            // ecrit mais ne passe pas à la ligne (pas writeligne)

            while (Nombrepropose == 0 || saisieint == 0)                              // refait tant que nombreproposé = 0 donc valeur par defaut, supposé donc que le joueur mets 0 ou que le converter n'a pas marché
            {

                Console.Write("Donner une nombre entre 1 et 99 : ");



                string saisie = Console.ReadLine();                             // prend un string et le mets dans saisie, attention a ne pas confondre 12 en caractere et 12 le chiffre, 
                                                                                //readline donne un string donc obligé de mettre un string pour saisie  
                                                                                //---> on pourrait mettre var au lieu de string : ça dit au compilateur de deviner ce qui sort de console read

                if (saisie == "YYY")        // on veut que si on ecrit YYY ça donne la reponse, or on a pas acces au nombre dans cette classe.. Du coup on l'envoie en meme temps que la demande d'utiliser kla methode
                {

                    Console.WriteLine(n);

                }





                // declare et mets à zero 
                if (int.TryParse(saisie, out saisieint))         // essaye de convertir le string de saisie en int et mettre dans saisieint
                {

                    Nombrepropose = saisieint;                  // le nombre prososé est 0 de base, si il reussi à le convertir, alors stocke dans nombreproposé



                }
                else
                {
                    Console.WriteLine("Ce n'est pas un nombre correct !");
                }
            }
        }

    }


}
