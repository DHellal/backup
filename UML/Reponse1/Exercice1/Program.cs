using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {

            Auto a1 = new Auto { Marque = "Clio (Renault)", Proprio = "monsieur K" };
            Moto m1 = new Moto { Marque = " 1450 FLHR (Harley Davidson)", Proprio = "Johnny", cylindre="grosse" };
            Auto a2 = new Auto { Marque = "Ds3 (Citroen)", Proprio = "Quing", modele="vroum" };


            Console.WriteLine("Le proprio de la {0} est {1}. \nLe proprio de la {2} {6} est {3}. \nLe proprio de la {4} {7} est {5}.",
                                                a1.Marque, a1.Proprio, a2.Marque, a2.Proprio, m1.Marque, m1.Proprio, a2.modele, m1.cylindre);

            Console.Read();
        }
    }

    public class Auto : Vehicule
    {
        public string modele;
    }

    public class Moto : Vehicule
    {
        public string cylindre;

    }

    public class Vehicule
    {
        public string Proprio;
        public string Marque;

    }


   

}

