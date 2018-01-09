using System;
using System.Collections;
using System.Collections.Generic;

namespace testentrainement
{
    internal class Personnes : IEnumerable<Personne>
    {


        private List<Personne> listeprivee = new List<Personne>();
      
        


        internal void Add(Personne personne)
        {
            listeprivee.Add(personne);
        }

        public IEnumerator<Personne> GetEnumerator()
        {
            return new PEENM(listeprivee);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PEENM(listeprivee);
        }

        public int Count{ get { return listeprivee.Count; } }

        public Personne this[int i]
        {
            get { return listeprivee[i]; }

        }






    }
}