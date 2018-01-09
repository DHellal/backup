using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {

            Cheval Jollyjumper = new Cheval();
            Jollyjumper.Allaiter();
            Console.Read();

        }
    }

    class Cheval : Mammifere  // Herite des proprietés de mammifere
    {
        // propriétés
        public string Nom;
        public int age;

        //Methodes
        public void Courrir()
        {
        }

    }

    class Mammifere : Animal
    {

        public void Allaiter()
        {
            Console.WriteLine("Allaitement en cours...");
        }

    }

    class chien : Mammifere
    {

    }

    class Animal
    {

    }  // Une classe ne peut pas heriter de plusieurs classes !!



}
