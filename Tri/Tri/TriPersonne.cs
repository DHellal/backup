using System;

namespace Tri
{
    internal class TriPersonne
    {

        public int Index = 0;
        private Personne[] Listepersonne = null;


        public bool Fini { get { return Index >= Listepersonne.Length - 1; } }

        internal bool IsInverser()
        {
            if (Croisssant)
                return Listepersonne[Index].DateNaissance > Listepersonne[Index + 1].DateNaissance;
            else
                return ListeEntier[Index] < ListeEntier[Index + 1];
        }

        internal void Inverser()
        {
            throw new NotImplementedException();
        }

        internal void Reset()
        {
            throw new NotImplementedException();
        }

        internal void Next()
        {
            throw new NotImplementedException();
        }

        internal void Affiche()
        {
            throw new NotImplementedException();
        }
    }
}