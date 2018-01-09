using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointerfacje
{
    class Program
    {
        static void Main(string[] args)
        {

            var Terre = new Planetehabitable { Yadlo = true };
            var Mars = new Planetehabitable { Yadlo = true };
            var Soleil = new Etoile { luminosite = 500, Masse = 200, rayon = 300 };
            var EtoileduNord = new Etoile { luminosite = 150, Masse = 100, rayon = 350 };

        }
    }



    class Planetehabitable : Astre, IHabitable , IHabite              // on peut pas la faire heriter d'habitable car double heritage impossible; du coup on implemente interface pour simuler un multi heritage
    {
        public bool Yadlo = false;

        public int Npopulation()
        {
            return 2;
        }

        public decimal Tauxoxygene()
        {
            return 0.3M;        // M pour dire que c'est un decimal car il voit 0.3 comme un double
        }

        public int Temperature()
        {
            return 25;
        }
    }


    class Etoile : Astre
    {
        public int luminosite;

    }


    class Astre
    {

        public int rayon;
        public int Masse;

    }


    interface IHabitable           // Pas de public ou privé ou de code dedans, elle ne contient que des methodes 
    {
        decimal Tauxoxygene();             // on defini des methodes, avec comme retour 20
        int Temperature();

    }


    interface IHabite
    {
        int Npopulation();

    }

}
