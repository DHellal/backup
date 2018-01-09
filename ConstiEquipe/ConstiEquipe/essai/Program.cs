using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace ConstitutionEquipe
{
    class Program
    {
        static void Main(string[] args)
        {
            #region data
            // 13 personnes - 3 équipes
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
            #endregion

            listePersonne.GetListeEquipe();

            Equipes listeEquipe = null;

            // Load
            Console.WriteLine("Ouvrir..");
            string saisie = Console.ReadLine();
            if (saisie != "")
            {
                listeEquipe = Equipes.Load(@"..\..\" + saisie + ".xml");
            }

            // Nouveau projet
            Console.WriteLine("Nouveau projet ? (O/N)");
            saisie = Console.ReadLine();

            if (saisie.ToUpper() == "O")
            {
                listeEquipe = new Equipes("Cyan", "Green", "Red");

                // Affectations
                while (listePersonne.Count > 0)
                {
                    Personne p3 = listePersonne.Remove();
                    Equipe e = listeEquipe.EquipeMin();
                    e.Add(p3);
                }

                // Sauvegarde
                Console.WriteLine("Enregistrer sous...");
                saisie = Console.ReadLine();
                listeEquipe.Save(@"..\..\" + saisie + ".xml");
            }
            // Affichage
            if (listeEquipe != null)
            {
                foreach (var equipe in listeEquipe)
                {
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), equipe.Nom);
                    Console.WriteLine(equipe);
                    foreach (var p2 in equipe)
                    {
                        Console.WriteLine("\t{0}", p2);
                    }
                    Console.WriteLine();
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Personne p = listeEquipe[1][1];
            Console.WriteLine(p.Prenom);
            foreach(var equipe in p.ListeEquipe)
            {
                Console.WriteLine(equipe);
            }
            Console.Read();
        }
    }
    [Serializable]
    class Personne
    {
        public string Prenom;
        public string Ville;
        public Equipes ListeEquipe = new Equipes();
        public override string ToString()
        {
            return Prenom;
        }
    }
    [Serializable]
    class Personnes : List<Personne>
    {
        private Random alea = new Random();

        internal void GetListeEquipe()
        {
            string path = @"S:\Denis\Code\Csharp\ConstiEquipe\ConstiEquipe\essai";
            string[] fichiers = Directory.GetFiles(path, "*.xml");
            foreach(var fichier in fichiers)
            {
                Equipes equipes = Equipes.Load(fichier);
                foreach(var equipe in equipes)
                {
                    foreach(var personneDuFichier in equipe)
                    {
                        var personneOriginelle = this
                            .Where(p => p.Prenom == personneDuFichier.Prenom)
                            .FirstOrDefault();
                        personneOriginelle.ListeEquipe.Add(equipe);
                    }
                }
            }
        }

        internal Personne Remove()
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

    [Serializable]
    class Equipes : List<Equipe>
    {
        public Equipes(params string[] nomEquipes) 
        {
            for (int i = 0; i < nomEquipes.Length; i++)
                Add(new Equipe { Nom = nomEquipes[i]});
        }


        internal Equipe EquipeMin()
        {
            return this.Where(e => e.Count == this.Min(e2 => e2.Count)).FirstOrDefault();
        }

        internal static Equipes Load(string nomFichier)
        {
            if (File.Exists(nomFichier))
            {
                IFormatter deserialiseur = null;
                FileStream flux = File.OpenRead(nomFichier);
                deserialiseur = new SoapFormatter();
                return (Equipes)deserialiseur.Deserialize(flux);
            }
            return null;
        }
        internal void Save(string nomFichier)
        {
            FileStream flux = File.Create(nomFichier);
            SoapFormatter serial = new SoapFormatter();
            serial.Serialize(flux, this);
            flux.Close();
        }
    }

}

