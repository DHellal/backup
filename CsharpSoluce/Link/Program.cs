using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {


            var listePersonne = new List<Personne>();
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



            var pAH = listePersonne.Where(p => p.Ville == "Athènes" || p.Ville == "Hochiminh");     // c'est du linq,   



            pAH = from p in listePersonne where p.Ville == "Bangui" || p.Ville == "Mexico" select p;         // autre facon d'ecrire



            //        if ("Ali".EndsWith("i"))        // si ali se termine par i


            pAH = listePersonne.Where(p => p.Ville.EndsWith("a"));      // pour un p  donné de listpersonne , on voit si p.ville fini ppar a, si oui on prends


            var listeprenom = listePersonne.Where(p => p.Ville == "Athènes" || p.Ville == "Hochiminh").Select(p => p.Prenom);   // ne slelecte que les prenoms



            var liste = listeprenom.ToArray();      // to array c'est pour vers tableau,  // le linq de base mets les données dans une case speciale , la ça transforme ce qu'il y'a dans les cases en tableau



            foreach (var p in pAH)
            {

                Console.WriteLine(p.Prenom);
                Console.WriteLine(p.Ville);

            }






            




            List<Planete> planetes = new List<Planete>();
            planetes.Add(new Planete { Nom = "Msoleil", Systeme = true, distance =1});
            planetes.Add(new Planete { Nom = "terre", Systeme = true, distance =2});
            planetes.Add(new Planete { Nom = "ars", Systeme = true, distance =3});
            planetes.Add(new Planete { Nom = "Mlopo", Systeme = true, distance =4});
            planetes.Add(new Planete { Nom = "tataouin", Systeme = true, distance =8});
            planetes.Add(new Planete { Nom = "vega", Systeme = true, distance =40});
            planetes.Add(new Planete { Nom = "ouinopn", Systeme = true, distance =50});




            var terre = planetes[2];

            var reponses = planetes.Where(p => p!= terre && p.distance - terre.distance <= 2 && p.Systeme);     // a noter que ce n'est pas executer direct, c'est executé que si c'est necessaire cad que l'on veut voir le resultat
        //    var reponses2 = reponses.Where(p => p.Nom.StartsWith("M"));      // ici non plus pas executer

            foreach(var reponse in reponses)
            {

                Console.WriteLine(reponse);         // ici elle essaye de convertir reponse to string pour afficher, celle de la classe object

            }



            //         var repinse3 = planetes.Where(p => p != terre).Select(p => new X { Nom = p.Nom, distat = Math.Abs(p.distance - terre.distance)}); // sinon on peut enlever le X et la classe et mettre juste new ( en fait ça fait une classe que l'on voit pas avec un ovveride to string et tout)



            var repinse3 = planetes.Where(p => p != terre).Select(p => new { Nom = p.Nom, distat = Math.Abs(p.distance - terre.distance) });


            Console.Read();





        }                                                        
    }
}
