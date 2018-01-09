using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N2;


// pour lui dire regarde dans l'autre assembly, il faut faire reference, add, et prendre celui qu'on veut



namespace N1            // on change l'espace de nom en N1

{


    public class Program
    {
        static void Main(string[] args)
        {


            Joueur j1 = new Joueur();
            j1.initialisej();

            Partie partie1 = new Partie();          // on fait un objet partie que l'on appelle partie1

            partie1.initialise();



            Statut resultat = Statut.Nondefini;         // on defini resultat ici car on en a besoin pour la boucle



            while (!(resultat == Statut.Gagne || resultat == Statut.Perdu)) // ou bien : (resultat != statu.gagne && resultat != statut.perdu)
            {

                j1.donnenombre(partie1.Nombremystere);

                resultat = partie1.Comparer(j1);               // compare les nombres, avec entrée  classe joueur j1 et stocjke dans statut resultat



                switch (resultat)
                {
                    case Statut.Troppetit:
                        Console.WriteLine("Trop petit !"); break;
                    case Statut.TropGrand:
                        Console.WriteLine("Trop grand !"); break;
                    case Statut.Gagne:
                        Console.WriteLine("Bravo"); break;
                    case Statut.Perdu:
                        Console.WriteLine("Perdu5"); break;

                }

            }

            Console.Read();


        }
    }

    


}
