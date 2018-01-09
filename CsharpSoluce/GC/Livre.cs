using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC
{
    class Livre : IDisposable
    {
        public void Dispose()           // GC lance cette methode au lieu de finalise
        {
            // on mets ici si on veut liberer d'autre ressources (connexion, fichier, etc)


          
        }
    }
}
