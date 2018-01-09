using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1du12dec
{
    public class Emplacement     // place A B et C
    {

        public string Nom;
        public List<piece> ListesurPieces = new List<piece>();

        public override string ToString()
        {
            return Nom.ToString();
        }

    }
}
