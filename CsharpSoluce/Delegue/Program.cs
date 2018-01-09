using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegue
{
    class Program
    {
        static void Main(string[] args)
        {


            // classique

            var projo = new Appareil { Nom = "Projecteur" };
            var dProjo = new MonDelegue(projo.Affiche);
         //   Console.WriteLine(dProjo());


            //Facilite d'ecriture

            
            MonDelegue dTablette = () => Console.WriteLine("tablette");     // condense le code, en fait fait une methode anonyme quoi




            Console.Read();


        }


    }


}
