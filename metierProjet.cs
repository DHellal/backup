using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier1


{

    public static class Metier
    {


        public static bool Authentifierl(string a)         // un mot de passe pour commercial
        {

            if (a == "motdepasse") return true;
            else return false;


        }

        public static void GererVoyages(int a)       // apres authentification, le commercial choisit ajouter, supprimer, Modifier un voyage (1 2 3)
        {

            Voyage.AfficheListeVoyage();      // faut deserilalizer et afficher liste ( methode statique dans voyage)


            switch (a)
            {
                case 1: Commercial.AjouteVoyage();   break;

                case 2: Commercial.SupprimeVoyage(); break;

                case 3: Commercial.ModifierVoyage(); break;

            }
        }
        
        public static void GereClient(Commercial c, int a)
        {

            Client.AfficheListe();     // idem qu'en haut



            switch (a)
            {

                case 1: c.AjouteClient(); break;
                case 2: c.ModifieClient(); break;
                case 3: c.SupprimeClient(); break;



            }

        }       // commercial qui gere les clients








    }



    public class Client
    {

        public Client()
        {
            if (1)      // si nouveau client

                numeroClient = GenereIDClient();

            else if (2) ;      //

            //desrialize et charge client (selon numero)        // faut donner numero client



        }


        public string nomClient;
        public string prenomClient;
        public DateTime datedeNaissance;
        public int numeroDossier;
        public string mail;
        public string telephone;
        public string adresse;
        public long numeroClient;
        private long numeroCarteB;
        public bool statut;         // true = particulier   false = societé
        public string nomSociete;
        public List<Dossier> listeDossierClient;            // a relier avec hafid

        public void FaireUneReservation(Client c)   // methode pour reservation ( voir avec Raja)   
        {






        }


        public void GererLesDossiers(long numeroclient)      // numero client en entré dans interface (on dit que si = 0 ^par defaut)
        {




        }

        public void Authentifier(long numeroclient)     //charge données selon ce numero de client
        {




        }

        public void EnregistreClient()
        {



        }


        public void ChargeClient()
        {



        }


        public long GenereIDClient()
        {

            return 1;       // id a generer

        }

        public static void AfficheListe()
        {


        }
        


    }


    public class Commercial
    {

        public string nomCommercial;
        public string prenom;
        public int numeroCommercial;




        // gere les voyages
        #region gerervoyage
        public static void AjouteVoyage()
        {

            Voyage Voyage = new Voyage();

        }

        internal static void SupprimeVoyage()
        {
            throw new NotImplementedException();
        }

        internal static void ModifierVoyage()
        {
            throw new NotImplementedException();
        }
        #endregion



        // gere les clients
        #region gereClient
        internal void AjouteClient()
        {
            throw new NotImplementedException();
        }

        internal void ModifieClient()
        {
            throw new NotImplementedException();
        }

        internal void SupprimeClient()
        {
            throw new NotImplementedException();
        }

        #endregion


    }



    public class Voyageur
    {
        public Voyageur()
        {
            promotion = Calculpromotion(dateDeNaissance);
        }

        public string nom;
        public string prenom;
        public DateTime dateDeNaissance;
        public bool promotion = false;

        public bool Calculpromotion(DateTime datedenaissance)
        {


            if (DateTime.Today.Year - dateDeNaissance.Year < 12)
                return true;
            else
                return false;
               


        }       // retourne vrai si moins 12 et a la promotion, sinon false

        
        

    }








    public class pro
    {

        public void Main()
        {
            Metier.GererVoyages();

        }

        

        

    }
}
