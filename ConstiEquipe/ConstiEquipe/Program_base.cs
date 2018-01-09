using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstiEquipe
{
    class Program_base
    {
        static void Main(string[] args)
        {

            int nEquipe = 3;


            Personnes listePersonne = new Personnes();
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
            listePersonne.Add(new Personne { Prenom = "Maurice", Ville = "Clamart" });



            List<Personnes> Equipes = Choisir(nEquipe);

            Afficher(Equipes);

            Console.Read();

           

           




        }

        

        private static List<Personnes> Choisir(int nEquipe)
        {

            Random alea = new Random();
             alea.Next()


        }



        private static void Afficher(List<Personnes> equipes)
        {
            throw new NotImplementedException();
        }

    }

    internal class Personnes : List<Personne>
    {
    }

    internal class Personne
    {
        public string Prenom { get; set; }
        public string Ville { get; set; }
    }
}
