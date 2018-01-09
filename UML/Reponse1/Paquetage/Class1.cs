using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espace1         // on a creer une autre fichier, on l'appelle espace1. Meme s'il y'a 2 fichiers espace1, c'est comme si il y'en avais qu'un avec toutes ces classes
{                           // ainsi je peux pas creer dans cet espace1 un truc qui existe deja dans l'autre  sauf si on mets partial devant:
    partial class Class1
    {
    }
}


namespace Espace2              // la on a definit un nouvel espace, meme si c'est le meme fichier, le compilateur les voit dans un espace different
{


}
