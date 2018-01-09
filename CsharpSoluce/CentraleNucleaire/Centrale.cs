using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentraleNucleaire
{
    class Centrale
    {


        public PompeElectrique Pe1 = new PompeElectrique();
        public PompeElectrique Pe2 = new PompeElectrique();
        public PompeHydraulique Ph1 = new PompeHydraulique();
        public PompeManuelle m1 = new PompeManuelle();

        

        event 


        ArrayList ListePompe = new ArrayList();         // une liste avec plusieurs classes dedans // quanjd on fait les deggués on peut faire une liste de delgué et donc : public List<RefroidirDelegate> Listedelegue = new List<Refroidirdelegate<();


        public Centrale()       // contructeur pour rassembler les pompes
        {

            ListePompe.Add(Ph1);            // on ferait pareil avec la liste delagate
            ListePompe.Add(Pe1);
            ListePompe.Add(Pe2);            //Listepompe += Pe2;        on peut ecrire ça comme ça..
            ListePompe.Add(m1);

        }


        RefroidirDelegate dh1 = new RefroidirDelegate(Pe1.Refroidir);       // on fait un delgué ou on mets les methodes refroidir pour chaque pompe
        RefroidirDelegate dh2 = new RefroidirDelegate(Pe2.Refroidir);


        public void Refroidir()
        {


            foreach(RefroidirDelegate d in LiseDelegate)
            {

                d.Invoke();     // appelle chaque methode, pour chauqe refroidir delegate // en fait on mets chaque methode en delegate (chaque delagate prends 1 methode) et ensuite on apelle chaque delegates de la liste

            }











            /*




        

            foreach(Object p in ListePompe)         // on peut dire pour chaque objet dans la liste car toutes les classes heritent d'objet
            {

                if (p is PompeHydraulique) ((PompeHydraulique)p).Refroidir();   // comme on sait pas ce que c'est, et que p est un objet, on convetit p en pompehydro ou electr selon



                else if (p is PompeElectrique) ((PompeElectrique)p).Refroidir();        // la flemme d'ecrire le nom des mpompes manuelles donc faut trouver autre chose

                else        // on arrive jamais ici normalement
                {
                    throw new Exception("erreur !!");
                }


            }





    */






        }




        // quand on definit un parametre d'entrée pour une 



    }
}
