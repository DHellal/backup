using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NStatut;


namespace NJeu

{
    public class Jeu
    {

        public ResultatEnum compare(Choix Chmachine, Choix chhumain)
        {


            if (Chmachine == chhumain)
                return ResultatEnum.Egalite;


            else if ((Chmachine == Choix.Ciseaux && chhumain == Choix.Pierre) || (Chmachine == Choix.Feuille && chhumain == Choix.Ciseaux) || (Chmachine == Choix.Pierre && chhumain == Choix.Feuille))
                return ResultatEnum.Gagne;

            else
                return ResultatEnum.Perdu;





        }

        public bool resultatpartie(int ma, int h)
        {
            if (trouvesigagne(ma, h)) { return true; }
            else
            return false;
        }

        private bool trouvesigagne(int m, int h)
        {

            if (m > h)
                return true;
            else
                return false;
        }
    }


    public class joueur
    {

        public Choix Choix = Choix.Indefini;
        public ResultatEnum Resulatat = ResultatEnum.Egalite;

        

        public bool Esthumain = false;

        public int points = 0;


        public bool AGagne() { return points >= 3; }                         //  on peut aussi faire une fonction qui va dire si oui ou non le joueur a gagné

        public Choix Choisir()
        {

            if (Esthumain)
                return Choisirpourhumain();
            else                                    // facultatif

                return chosirpourmachine();




        }

         

        #region Choisir


        private Choix chosirpourmachine()
        {
            Random alea = new Random();
            int i = alea.Next(1, 4);

            // resumachine = i;
            

            switch (i)

            {
                case 1: return Choix.Ciseaux;
                case 2: return Choix.Feuille;
                case 3: return Choix.Pierre;
                default: return Choix.Indefini;             // pour dire au compilateur que sinon ça, il est content


            }


        }



        private Choix Choisirpourhumain()
        {
            Console.Write("1.Pierre   -  2.Ciseaux    -   3.Feuille\n");
            int choix = 0;

            while (choix == 0)
            {

                string saisie = Console.ReadLine();

                if (int.TryParse(saisie, out choix) && choix >= 1 && choix <= 3)
                {

                    switch (choix)
                    {


                        case 1: return Choix.Pierre;
                        case 2: return Choix.Ciseaux;

                        case 3: return Choix.Feuille;
                        default: return Choix.Indefini;



                    }


                }

                else
                {
                    choix = 0; // au cas ou on mets une lettre par exemple il redeamdne

                    Console.WriteLine("Reessaye ! ");
                }



            }

            return Choix.Indefini;
        }


        #endregion          // on regroupe en region



    }











}




namespace NStatut
{

    public enum Choix
    {
        Indefini,
        Pierre,
        Ciseaux,
        Feuille


    }

    public enum ResultatEnum
    {
        Egalite,
        Gagne,
        Perdu
    }

}

