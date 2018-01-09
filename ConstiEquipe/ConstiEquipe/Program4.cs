using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace ConstitutionEquipe
{
    class Program
    {

        
        static void Main(string[] args)
        {
            
            


            // 13 personnes - 3 équipes
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

            Equipes listeEquipe = new Equipes("Coco", "ouioui", "nonon");



            while (listePersonne.Count > 0)
            {

                Personne p = listePersonne.Remove();
                Equipe e = listeEquipe.EquipeMin();
                e.Add(p);

            }




            foreach (var a in listeEquipe)
            {

                Console.WriteLine("\n" + a);
                foreach (var l in a)
                {

                    Console.WriteLine(l);

                }

            }
            Console.Read();




            listeEquipe.save(listeEquipe);


            
        
        
        






    }
}
    [Serializable]
    internal class Equipes : List<Equipe>

{

        private const string FICHIER_XML = @"..\..\listeEquipes.xml";

        public Equipes(params string[] nomEquipes)      // pour dire parametres en entrées on les prends tous en tableau de string
    {
        for (int i = 0; i < nomEquipes.Length; i++) Add(new Equipe { Nom = nomEquipes[i] });

    }


        
    internal Equipe EquipeMin()
    {
        return this.Where(e => e.Count == this.Min(e2 => e2.Count)).FirstOrDefault(); // retourne l'equipe avec le moins de personnes
    }

        internal void save(Equipes eq)
        {
            FileStream flux = File.Create(FICHIER_XML);
            SoapFormatter serialiseur2 = new SoapFormatter();
            serialiseur2.Serialize(flux, eq);
            flux.Close();
        }
    }

    [Serializable]
    class Personne
{
    public string Prenom;
    public string Ville;

    public override string ToString()
    {
        return Prenom;
    }


}

    [Serializable]
    class Personnes : List<Personne>
{

    private Random alea = new Random();     // on le mets ici car on veut generer le generateur alea qu'une fois

    public Personne Remove()
    {

        int index = alea.Next(0, this.Count);
        Personne p = this[index];
        this.RemoveAt(index);
        return p;
    }




}

    [Serializable]
    class Equipe : Personnes
{
    public string Nom;

    public override string ToString()
    {
        return Nom;
    }




}

}

