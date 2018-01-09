using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] tabEntier = new int[3];       // On doit definir une taille au depart, ici 3
            tabEntier[0] = 12;
            tabEntier[1] = 35;
            tabEntier[2] = 12;


            // sinon on peut mettre int[] tabentier = {10, 20, 30};         // ca declare et instante etc en meme temps



            string[,] tab2D = { { "e", "d", "e" }, { "e", "d", "d" } };     // faut remplir toutes les cases..



            string[,,] tab3D = new string[3, 4, 5];     // tableau de string a 3 dimensions

            tab3D[0, 0, 0] = "Paris";
            // ..


            Personne[] tableaupersonnne = new Personne[3];      // tableau de personnes

            tableaupersonnne[0] = new Personne { nom = "Alfred", age = 10 };
            tableaupersonnne[1] = new Personne { nom = "Alfrd", age = 10 };
            tableaupersonnne[2] = new Personne { nom = "lfred", age = 10 };
            


            int ntabprsonne = tableaupersonnne.Length;      // donne longueur 

            int ndim = tab3D.Rank;      // 

            // il existe plusieurs methodes avec les tableaux : cloner, se ranger, etc..

            int dernierevaleur = tabEntier[tabEntier.Length - 1];   // on fait la longueur -1



            //Foreach

            foreach (Personne p in tableaupersonnne)        // pour chaque personne p dans tableaupersonne
            {

                Console.WriteLine(p.nom);
            }






        }
    }
}
