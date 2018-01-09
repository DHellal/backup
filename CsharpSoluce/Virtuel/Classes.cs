using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuel
{
    class Vehicule
    {       
        public virtual  void Rouler() { // blabla sur les vehicules              // on dit qu'elle est virtuelle pour etre remplacée
        }

       

    }



    class Auto : Vehicule
    {
        public override void Rouler()               // ici les 2 methodes ont la meme signatures.. donc on mets ovveride pour dire que celle ci prends le dessus 
        { //autre blabla sur les voiture
        }


    }
        


    class Moto : Vehicule
    {
        public override void Rouler()
        {


        }


    }



    class harley : Moto
    {

        public override void Rouler()       // ici ovverinde un ovveride, c'est ok car override est virtuel
        {
            base.Rouler();          // ici base dit que il faut utiliser la methode au dessus et non roule de harley
        }


    }



    class Avion : Vehicule
    {


        public virtual new void Rouler() { }        // casse l'heritage et utilise la methode mere
    }




}
