using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitache
{
    class Program
    {
        static void Main(string[] args)
        {


            Compteur jaune = new Compteur();

            Compteur bleu = new Compteur { Min = 1, Max = 20, Pas = 2, Pause = 100, Couleur =ConsoleColor.Magenta };

            Compteur red = new Compteur { Min = 11, Max = 50, Pas = 2, Pause = 50, Couleur = ConsoleColor.Cyan };


            // jaune.Compte();

            //bleu.Compte();          // on veut ça en meme temps, on les mets dans delegates


            CompteDelegate jauneD = new CompteDelegate(jaune.Compte);       // on fait un delagué objet ou on mets la methode compte jauine

            CompteDelegate bleuD = new CompteDelegate(bleu.Compte);

            CompteDelegate redD = new CompteDelegate(red.Compte);





            //   jauneD();       // invoque le delegué mais un par un
            //   bleuD.Invoke();


            jauneD.BeginInvoke(new AsyncCallback(JauneFini), null);     // ici lance sur un thread et apres appelle la fonction jaunefini

      //      jauneD.BeginInvoke(null, null);   //lance et passe meme si pas fini     ---------> parralelisation !!       // a noter que comme ça part en parallele les parametres se melangent..
            bleuD.BeginInvoke(null, null);
            redD();



            Console.Read();











        }

        private static void JauneFini(IAsyncResult ar)
        {
            Console.WriteLine("Jaune fini !");
        }
    }

}
