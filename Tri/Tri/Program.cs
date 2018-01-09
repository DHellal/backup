using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri
{
     class Program
    {
        static void Main(string[] args)
        {
            
            int[] taenttier = { 99, 12, 1, 2, 12, 65, 89, 1, 36 };

            //// autre ecriture : 
            //int[] taentier = new int[6];
            //taentier[0] = 99;
            //...

            int[] resultat =  tri.triage(taenttier);

            foreach(int p in taenttier)
            {
                Console.WriteLine(p);


            }

            Console.Read();


        }
    }
}
