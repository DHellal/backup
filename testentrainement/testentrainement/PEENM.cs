using System;
using System.Collections;
using System.Collections.Generic;

namespace testentrainement
{
    internal class PEENM : IEnumerator<Personne>
    {
        private List<Personne> listepri;

        int index = -1;

        public PEENM(List<Personne> liste)
        {
            listepri = liste;
            
        }


        

        public Personne Current
        {
            get
            {
                return listepri[index];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return listepri[index];
            }
        }

        public void Dispose()
        {
           
        }

        public bool MoveNext()
        {
            index++;
            return index < listepri.Count;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}