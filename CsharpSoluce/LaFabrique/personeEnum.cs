using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaFabrique
{

    class PersonneEnumerateur : IEnumerator<Personne>       // on fait une classe pour interface, maintenant il faut implementer les methodes necessaires via IEnum
    {


        private List<Personne> listeprivee2;        // une liste qui va etre utilisée ici, qui va prends les paralmete de liste privee

        private int Index = -1;     // car on lance un movenext en premier don ça va prendre 0 en premier car ++


        public PersonneEnumerateur(List<Personne> liste)     // on dit que la liste privée (vrai) est appelée et est mise dans liste
        {
            listeprivee2 = liste;
        }


        public Personne Current         // personne en cours : pour enumerer
        {
            get
            {
                return listeprivee2[Index];     // il regarde y'a quoi
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return listeprivee2[Index];     // qq fois  il passe par la 
            }
        }


        public void Dispose()
        {
            
        }

        public bool MoveNext()      // passe au suivant
        {
            Index++;                //
            return Index < listeprivee2.Count;      // regarde si on n'est pas à al fin de la lsite  -> retourne vrai (bool ! )           // cont c'est pour les collection, lenght c'est pour les tableau
        }

        public void Reset()     // reset
        {
            Index = -1;
        }
    }








}



    