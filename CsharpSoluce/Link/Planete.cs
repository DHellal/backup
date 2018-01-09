using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Planete
    {


        public string Nom;
        public bool Systeme;

        public int distance;


        public override string ToString()       // on ovverride la methode to string d'objet avec le to string de la classe
        {
            return Nom + ";" + distance.ToString();
        }


    }
}
