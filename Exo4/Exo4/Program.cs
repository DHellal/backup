using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Exo4
{
    class Program
    {

        private const string FICHIER_BIN = @"..\personnage.bin";
        private const string FICHIER_XML = @"..\personnage.xml";

        static void Main(string[] args)
        {


            
            
            
            int saisie = 0;

            

            List<Personne> listedepersonne = new List<Personne>();

            Console.WriteLine("Bonjour ! \n1-Saisie \n2-Recherche");

            string Saisieclient = Console.ReadLine();

            int.TryParse(Saisieclient, out saisie);

            


            if (saisie == 0 || saisie > 2) Console.WriteLine("erreur !");

            else
            {
                
                BinaryFormatter seriabinaire = new BinaryFormatter();
                List<Personne> listederi = null;

                FileStream flux2 = File.OpenRead(FICHIER_BIN);
                

                switch (saisie)
                {



                    case 1:         //si saisie


                        

                        listederi = (List<Personne>)seriabinaire.Deserialize(flux2);
                        flux2.Close();

                        listedepersonne = listederi;


                        string Nom;
                        string Prenom;
                        string datedenaissance;         // on peut aussi faire un DateTime au lieu de string et prends datetime.minvalue comme valeur de depart par ex (ou null sinon)
                        

                        Console.WriteLine("Votre Nom ?");

                        Nom = (Console.ReadLine());           // readline permet de stocker un string


                        Console.WriteLine("Prenom ?");

                        Prenom = Console.ReadLine();

                        Console.WriteLine("Date de naissance ? (jj/mm/aaaa) ");

                        datedenaissance = Console.ReadLine();       // si on avait pris un datetime : il faut convetrtir , donc : datetime.tryparse(saisie, p.datedenaissance);
                        
                        listedepersonne.Add(new Personne { Nom = Nom, Prenom = Prenom, Datedenaissance = datedenaissance }); // on creer une nouvelle personne avec les infos



                        FileStream flux = File.Create(FICHIER_BIN);
                        seriabinaire.Serialize(flux, listedepersonne);
                        flux.Close();           // toujours penser à fermer le flux !!


                        Console.WriteLine("Merci !");

                        Console.Read();





                        break;


                    case 2:         // si recherche


                        

                        listederi = (List<Personne>)seriabinaire.Deserialize(flux2);
                        flux2.Close();

                        Console.WriteLine("Votre Date (jj/mm/aaaa ?");

                        string datesaisie = Console.ReadLine();

                        var per = listederi.Where(p => (p.Datedenaissance).Contains(datesaisie));           // on aurait pu faire p.datdenaissance.year si on avit pris la variabl datetime

                        


                        foreach( var p in per){

                            Console.WriteLine(p.Nom, p.Prenom);         // sinon on peut mettre le override to string de personne ( car il prends le string  de p !!



                        }
                        


                        Console.Read();

                        


                        //string saisienom = Console.ReadLine();



                        


                        



                        Console.Read();

                        break;








                }









            }



        }
    }
}
