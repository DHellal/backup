using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisationAttribut
{
    class Program
    {
        static void Main(string[] args)
        {
            Maison m1 = new Maison();
            m1.MettreChauffage();

            var atts = m1.GetType().GetCustomAttributes(false);     //recupere classe maison, donne toute methodes de la classe maison et heritée, et mtn recupere attributs
            string nom = ((DevelopperParAttribute)atts[0]).Nom;     // ici on prends l'attribut et on voit le nom


            var methodes = m1.GetType();        // demande y'a quoi comme methode


        }
    }
    [DevelopperPar("Ali MAKRI")]
    class Maison
    {
        [Obsolete("Utiliser l'autre version")]
        public void MettreChauffage()
        {

        }
        [DevelopperPar("Alice")]
        public void MettreChauffage(int temperature)
        {

        }
    }
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class DevelopperParAttribute : Attribute        // on fait une classe attribut (heritage), par def on mets attibute derriere nom attribut
    {
        public string Nom;         // on stocke le nom
        public DevelopperParAttribute(string nom)
        {
            Nom = nom;
        }
    }
}
