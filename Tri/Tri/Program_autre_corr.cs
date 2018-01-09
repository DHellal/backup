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
            TriPersonne trip = new TriPersonne(ListePersonne);
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

            Console.Read();

        }
    }

    internal class TriPersonne
    {
        public int Index = 0;
        public bool Croissant = true;
        public Personne[] ListePersonne = null;
        public TriPersonne(Personne[] liste, bool croissant = true)
        {
            ListePersonne = liste;
            Croissant = croissant;
        }
        public bool Fini
        {
            get { return Index >= ListePersonne.Length - 1; }
        }

        internal void Affiche()
        {
            foreach (Personne p in ListePersonne)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }

        internal void Inverser()
        {
            Personne temp = ListePersonne[Index + 1];
            ListePersonne[Index + 1] = ListePersonne[Index];
            ListePersonne[Index] = temp;
        }

        internal bool IsInverser()
        {
            if (Croissant)
                return ListePersonne[Index].DateNaissance > ListePersonne[Index + 1].DateNaissance;
            else
                return ListePersonne[Index].DateNaissance < ListePersonne[Index + 1].DateNaissance;
        }

        internal void Next()
        {
            Index++;
        }

        internal void Reset()
        {
            Index = 0;
        }
    }

    internal class Personne
    {
        internal DateTime DateNaissance;
        internal string Nom;
        public override string ToString()
        {
            return string.Format("{0} : {1}", Nom, DateNaissance.ToShortDateString());
        }
    }

    class TriEntier
    {
        private bool Croissant = true;
        private int[] ListeEntier = null;
        public TriEntier(int[] liste, bool croissant = true)
        {
            ListeEntier = liste;
            Croissant = croissant;
        }
        public int Index = 0;
        public bool Fini
        {
            get { return Index >= ListeEntier.Length - 1; }
        }

        internal bool IsInverser()
        {
            if (Croissant)
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
            
            Console.ReadLine();
        }
    }
}
