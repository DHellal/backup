using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation
{
    class Program
    {
        private const string FICHIER_BINAIRE = @"..\..\listeSalle.bin";
        private const string FICHIER_XML = @"..\..\listeSalle.xml";
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sérialiser \n2.Désérialiser \n Tapez 1 ou 2");
            string saisie = Console.ReadLine();
            switch(saisie)
            {
                case "1": Serialiser(); break;
                //case "2": Deserialiser(); break;
            }

        }

        private static void Serialiser()
        {
            // Création de la liste
            var listePersonne = new Personnes();
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

            // Sérialisation
            Console.WriteLine("1. Binaire \n2.XML \n Tapez 1 ou 2");
            string saisie = Console.ReadLine();
            switch (saisie)
            {
                case "1":
                    FileStream flux = File.Create(FICHIER_BINAIRE);
                    BinaryFormatter serialiseur = new BinaryFormatter();        //
                    serialiseur.Serialize(flux, listePersonne);
                    flux.Close();
                    break;
                case "2":
                    flux = File.Create(FICHIER_XML);            // probleme de declaration 2 fois
                    SoapFormatter serialiseur2 = new SoapFormatter();       // faut ajouter soap avant
                    serialiseur2.Serialize(flux, listePersonne);
                    flux.Close();
                    break;
            }
        }
    }
    [Serializable]
    class Personne
    {
        public string Prenom;
        public string Ville;
    }

    [Serializable]

    class Personnes : List<Personne>        // vu qu'il serialise pas la liste, on a fait une classe heritant d'une liste, ,et dit qu'elle est serialisée
    {


    }


}
