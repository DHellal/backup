using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaFabrique
{
    class Personnes : IEnumerable<Personne>                            // : List<Personne>   une solution est de faire que ppersonne est une liste de personne en heritage
    {

        private List<Personne> Listeprivee = new List<Personne>();          // on dit qu'on utilise la classe personnes comme si elel mem etait une classe



        public void Add(Personne p)     // on lui apprends la fonction Add que seule la liste connaissait

        {

            Listeprivee.Add(p);         //on lui mets

        }






// il implemente les 2 methodes de l'interface Ienumerable
        public IEnumerator<Personne> GetEnumerator()            // il faut retourner une interface Ienumerator de personne... or on ne peut pas construire une interface, donc on va retourner un objet d'une classe qui implemente l'interface
        {
            return new PersonneEnumerateur(Listeprivee);            // on donne la liste privée en parametree pour pouvoir l'utiliser dans une classe 
        }


    






        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }











        public int Count {  get { return Listeprivee.Count; } }         // En gros on definit listepreivee en prive qui est une liste, et on dit que personne prends les paramettre pour elle  // on passe par le le get car on veut faire une propriete (variable) qui se comporte comme une methode


        public Personne this[int i]         // ça vuet dire que qd on mets crochet i, il donne la personne dans la listeprivee i
        {

            get { return Listeprivee[i]; }      

        }

    }
}
