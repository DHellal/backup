using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaFabrique            // en gros on prends une classe , definit une liste privé dedans et on fait en sorte ( en ajoutant les methodes necessaire pour relier la classe et sa liste) que la classe se comporte comme la lsite dedans (en gros la classe est l'intermediarie de sa lsite)        ça sert pour par exemple proteger des données qui passe que via l'objet de la classe, controlée
{                               // du coup on definit nous meme les methodes qui vont servir de liens et aisni on peut aussi mettre les restruction ne cessaires
    class Program
    {
        static void Main(string[] args)
        {

            var listePersonne = new Personnes();        // On veut utiliser la classe personnes comme une liste alors qu'en fait c'est une classe contenant une liste


                
                listePersonne.Add(new Personne { Prenom = "Théodoros", Ville = "Athènes" });
                listePersonne.Add(new Personne { Prenom = "Thi Qui Khanh", Ville = "Hochiminh" });
                listePersonne.Add(new Personne { Prenom = "Lydia", Ville = "Bangui" });
                listePersonne.Add(new Personne { Prenom = "Niry", Ville = "Tana" });
                listePersonne.Add(new Personne { Prenom = "Velio", Ville = "Mexico" });
                listePersonne.Add(new Personne { Prenom = "Hédi", Ville = "Melun" });
                listePersonne.Add(new Personne { Prenom = "Raja", Ville = "Agadir" });
                listePersonne.Add(new Personne { Prenom = "Yiqing", Ville = "Shanghai" });
                listePersonne.Add(new Personne { Prenom = "Armelle", Ville = "Douala" });
                listePersonne.Add(new Personne { Prenom = "Denis", Ville = "Paris" });
                listePersonne.Add(new Personne { Prenom = "Hafid", Ville = "Bejaia" });
                listePersonne.Add(new Personne { Prenom = "Pierre Yves", Ville = "Nancy" });
                listePersonne.Add(new Personne { Prenom = "Ali", Ville = "Lyon" });
                listePersonne.Add(new Personne { Prenom = "Maurice", Ville = "Clamart" });






            int indexAgadir;    
            for (int i=0; i< listePersonne.Count; i++)          //      on cherche la personne ayant vilel agadir
            {

                if (listePersonne[i].Ville == "Agadir")     // les crochets ne fonctionnent pas car pas cvraie liste... alors on les defnit comem des operateur  : icic on envoi un entier i et on reprend une liste de personne
                {

                    indexAgadir = i;
                    break;

                }

            }




            Personne pTana;
            foreach(Personne p in listePersonne)        // il peut pas regarder dans la listepersonne car ce n'est pas une colelction   : il faut implementer une interface IEnumerable<Personne> pour qu'elle devienne enumerable en personne (voir dessin Csharp17)
            {                                           // il regarde chaque personne sans s dans la liste de la classe personnes avec un s 

                if (p.Ville == "Tana")
                {
                    pTana = p;
                }


            }





        }
    }
}
