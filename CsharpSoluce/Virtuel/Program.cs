using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuel
{
    class Program
    {
        static void Main(string[] args)
        {

            Auto Ds = new Auto();

            Ds.Rouler();



            //        Vehicule tracteur = new Auto();         // ici c'est une vehicule mais se comporte comme une auto


            Vehicule v;
            if (Console.ReadLine() == "A")
                v = new Auto();
            else
                v = new Moto();

            v.Rouler();             // selon ce qu'on va mettre il se comportera differement en moto ou auto





            Console.Read();



        }
    }
}
