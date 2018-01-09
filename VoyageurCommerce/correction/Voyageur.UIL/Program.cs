using System;
using System.Collections.Generic;
using System.Linq;
using Voyageur.BOL;

namespace Voyageur.UIL
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saisies
            MaConsole console = new MaConsole();
            do
            {
                console.SaisirVille();
            } while (!console.FinSaisie());

            // Métier
            string reponse = Metier.ParcoursLePlusCourt(console.VillesChoisies);
            Console.WriteLine(reponse);

            Console.Read();
        }
    }
    class MaConsole
    {
        internal List<string> VillesChoisies = new List<string>();
        internal bool FinSaisie()
        {
            Console.WriteLine("Fin ? (O/N)");
            string saisie = Console.ReadLine();
            return saisie.ToUpper() == "O";
        }

        internal void SaisirVille()
        {
            Console.Write("Donner une ville : ");
            string saisie = Console.ReadLine();
            if (VillesChoisies.Where(v => v == saisie).FirstOrDefault() == null)
            {
                VillesChoisies.Add(saisie.ToUpper());
            }
            else
                Console.WriteLine("Ville déjà saisie !");
        }
    }
}
