using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {





            CarteBancaire carte1 = new CarteBancaire
            {
                Type = "Visa",
                Numero = "000 0 00 00 0000",
                Moisdevalidite = 4,
                Anneevalidite = 18,
                Titulaire = "MAKRI",
                Cryptogramme = "142",
                // on ne peut pas mettre le code secret mtn : on ne peut pas initialiser avec des methodes !!! Mais ça marche avec la version 2 !!!
                // en fait on fait appel à la fonction Set de la methode; c'est comme si on ecrit carte1.SetCodeSecret = "1234";
                //demandeur = "banque",
                demandeurv2 = new Personne { Nom = "MAKRI" },           // version ou la construction se fait dans l'instanciation de la carte1
                
                
               // Codesecret = "1234"
            };

            //    carte1.demandeur.Nom = "MAKRI";       version ou l'instanciation est faire dans la classe carte bancaire

            //   carte1.demandeurv2 = new Personne { Nom = "MAKRI" };            // autre version ou l'instanciation est la mais la declaration de la variable est dans classe carte bancaire

            carte1.Codesecret = "4567";

        //  Personne moi  = new Personne { Nom = "MAKRI" };

            // on pourrait aussi ecrire Cartebancaire carte1 = new cartebancaire()    et ensuite
            // carte1.type = "visa" etc...


            
            // carte1.SetCodeSecret("1234"); // lance la methode qui mets 1234 dans value et donc code secret devient value




            Console.WriteLine("Le code secret de la carte de " + carte1.Titulaire + " de est {0}",  carte1.Codesecret); // ne pas oublier les parentheses si on utilise la methode, si on utilise la variable avec string pas la peine
            Console.Read();




        }
    }


    public class CarteBancaire
    {

        public string Type;
        public string Numero; // ici en string car pas de calcul dessus
        public int Moisdevalidite;
        public int Anneevalidite;
        public string Titulaire;
        public string Cryptogramme;
       // private string codesecret;  // si le code est private, on ne peut pas le voir dans programme
  //      public Personne demandeur = new Personne();   // ici je dois dire new car c'est une classe de type reference !! donc l'instanciation est par defaut !
        public Personne demandeurv2;





        //public string GetCodeSecret() // creation d'une methode qui retourne un string
        //{
        //    return CodeSecret;      // qui est le code secret
        //}

        //public void SetCodeSecret(string value) // methode qui retourne rien mais qui prends en valeur un string du nom de value
        //{
        //    CodeSecret = value;
        //} 



        // On peut aussi ecrire, version 2  :  

        private string codesecret;
        public string Codesecret                 //(avec les majusules ici)
        {
            get
            {
                if (demandeurv2.Nom == "MAKRI")
                    return codesecret;

                else
                    return "non";
            }


            set
            {
                if (demandeurv2.Nom == "MAKRI")
                { codesecret = value; }
               
               
               
              
            }
            //Ici la methode publique permet la lecture et l'ecriture de CodeSecret




        }



    }

       

   

    public class Personne
    {
        public string Nom;


    }
}
