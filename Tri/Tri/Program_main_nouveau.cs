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
            // **************************************************************************************
            //int[] tabEntier = new int[6];
            //tabEntier[0] = 99;
            // ...

            int[] tabEntier = { 99, 12, 1, 12, 89, 2 };
            TriEntier tri = new TriEntier(tabEntier);
            while (!tri.Fini)
            {
                if (tri.IsInverser())
                {
                    tri.Inverser();
                    tri.Reset();
                }
                else
                {
                    tri.Next();
                }
            }
            tri.Affiche();

            // **************************************************************************************
            Personne[] ListePersonne =
            {
                new Personne {Nom="Bernard", DateNaissance=new DateTime(1970, 8, 15) },
                new Personne {Nom="Albert", DateNaissance=new DateTime(1960, 12, 18) },
                new Personne {Nom="Charlotte", DateNaissance=new DateTime(1980, 5, 11) }
            };

            TriPersonne trip = new TriPersonne();
            while (!trip.Fini)
            {
                if (trip.IsInverser())
                {
                    trip.Inverser();
                    trip.Reset();
                }
                else
                {
                    trip.Next();
                }
            }
            trip.Affiche();

        }
    }
    class TriEntier
    {
        private bool Croisssant = true;
        private int[] ListeEntier = null;
        public TriEntier(int[] liste, bool croissant = true)        // co
        {
            ListeEntier = liste;
            Croisssant = croissant;
        }
        public int Index = 0;
        public bool Fini
        {
            get { return Index >= ListeEntier.Length - 1; }
        }

        internal bool IsInverser()
        {
            if (Croisssant)
                return ListeEntier[Index] > ListeEntier[Index + 1];
            else
                return ListeEntier[Index] < ListeEntier[Index + 1];

        }

        internal void Inverser()
        {
            int temp = ListeEntier[Index + 1];
            ListeEntier[Index + 1] = ListeEntier[Index];
            ListeEntier[Index] = temp;
        }

        internal void Reset()
        {
            Index = 0;
        }

        internal void Next()
        {
            Index++;
        }

        internal void Affiche()
        {
            foreach (int i in ListeEntier)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
