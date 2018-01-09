using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo4
{

    [Serializable]
    class Personne
    {

        public string Nom;
        public string Prenom;
        public string Datedenaissance;

        public override string ToString()
        {
            return Nom +"" + Prenom;
        }

    }
}
