using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    class Maison            // on peut mettre aussi static et alors tout ce qui estr dedans doit etre static
    {

       // private Maison        si on fait ça on fait une classe privée donc non instanciable


        public Maison() : this("jaune")     // avec this on dit que on fait appel au constructeur à coté, et on dit ici qu'il est jaune
        { }     // ça c'est une methode de base ici, meme si invisible, c'est celle par dafault;    on doit le faire si on veut definri d'autre constructeur et tout de meme utiliser celui par defaut


        public string couleur = "bleu";

        public Maison(string c)     // le constructeur c'est une methode qui a meme nom que classe      :    on peut faire ctor +tab tab
        {
            couleur = c;


        }


        public const bool Fondation = true;     // il faut direct dire la valeur qu'elle prends et elle ne peut changer (donc ici tjrs true)

        public readonly int Surf;       // comme const mais on n'est pas obligé d'affecter la valeur direct

    }
}
