using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Joueur humain = new Joueur { EstHumain = true };
            Joueur machine = new Joueur { EstHumain = false };
            Jeu partie = new Jeu();

            while (! humain.AGagne() && ! machine.AGagne())
            {
                var choixHumain = humain.Choisir();
                var choixMachine = machine.Choisir();
                var resultat = partie.Comparer(choixMachine, choixHumain);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string s="";
                switch (resultat)
                {
                    case ResultatEnum.Gagne:
                        humain.Points++;
                        machine.Points = 0;
                        s = "Gagné";
                        break;
                    case ResultatEnum.Perdu:
                        machine.Points++;
                        humain.Points = 0;
                        s = "Perdu";
                        break;
                    case ResultatEnum.Egalite:
                        humain.Points = 0;
                        machine.Points = 0;
                        s = "Egalité";
                        break;
                }
                Console.WriteLine("{0} - {1} : {4} - {2}/{3}", choixHumain, choixMachine, humain.Points, machine.Points, s);
            }
            partie.ResultatFinal(humain);

            Console.Read();
        }
    }
    class Joueur
    {
        public ChoixEnum Choix = ChoixEnum.Indefini;
        public ResultatEnum Resultat = ResultatEnum.Egalite;
        public bool EstHumain = false;
        public int Points = 0;

        #region Choisir
        public ChoixEnum Choisir()
        {
            if (EstHumain)
                return ChoisirPourHumain();
            else
                return ChoisirPourMachine();
        }
        private ChoixEnum ChoisirPourMachine()
        {
            Random alea = new Random();
            int i = alea.Next(1, 4);
            switch (i)
            {
                case 1: return ChoixEnum.Pierre;
                case 2: return ChoixEnum.Feuille;
                case 3: return ChoixEnum.Ciseau;
                default: return ChoixEnum.Indefini;
            }
        }
        private ChoixEnum ChoisirPourHumain()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int choix = 0;
            while (choix == 0)
            {
                Console.Write("1. Pierre -  2. Feuille - 3. Ciseau : ");
                string saisie = Console.ReadLine();
                if (int.TryParse(saisie, out choix) && choix >= 1 && choix <= 3)
                {
                    switch (choix)
                    {
                        case 1: return ChoixEnum.Pierre;
                        case 2: return ChoixEnum.Feuille;
                        case 3: return ChoixEnum.Ciseau;
                        default: return ChoixEnum.Indefini;
                    }
                }
                else
                    choix = 0;
            }
            return ChoixEnum.Indefini;
        }
        #endregion

        public bool AGagne() { return Points >= 3; }
    }
    enum ChoixEnum { Indefini, Pierre, Feuille, Ciseau }
    enum ResultatEnum { Egalite, Gagne, Perdu }
    class Jeu
    {
        public ResultatEnum Comparer(ChoixEnum choixMachine, ChoixEnum choixHumain)
        {
            if (choixMachine == choixHumain)
                return ResultatEnum.Egalite;
            if (
                (choixMachine == ChoixEnum.Pierre && choixHumain == ChoixEnum.Ciseau) ||
                (choixMachine == ChoixEnum.Feuille && choixHumain == ChoixEnum.Pierre) ||
                (choixMachine == ChoixEnum.Ciseau && choixHumain == ChoixEnum.Feuille)
                )
                return ResultatEnum.Perdu;
            return ResultatEnum.Gagne;
        }

        internal void ResultatFinal(Joueur humain)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (humain.AGagne())
                Console.WriteLine("Vous avez gagné !");
            else
                Console.WriteLine("Vous avez perdu !");
        }
    }
}
