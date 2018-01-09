using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeDExtension// ancienne version
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Microsoft fournit au travers de la plateforme .Net un ensemble d'outils.";
            int nombreMots = phrase.NombreMots();
  //           int nombreMots = Outils.NombreMots(phrase);      // version 1
        }
    }
    public static class Outils
    {
        public static int NombreMots(this string s)     // method d'extension, fait croire qu'elle fait partie de la classe mais pas acces privé en fait : la tout les string ont un .Nbrmots
        {
            return s.Split(new char[] { ' ', '\'' },StringSplitOptions.RemoveEmptyEntries).Length;     // fait tableau de la phrase avec comme separateur un espace, on ciompte le tableau alors et on a le nbr de mots, sans compter double espaces et prennant compte '

        }
    }
}
