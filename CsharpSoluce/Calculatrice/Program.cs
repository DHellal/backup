using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculatrice cal = new Calculatrice();

            int resultat = cal.Mul(cal.Add(3, 4), 5);


            double res = cal.Sinus(90);


            int i = -12;

            cal.Moins(ref i);       // on veut changer i



            var r = cal.Suite(5); // On lit l'objet retourné par la methode et on le stocke dans r (en fait on pointe dessus avec r


        }
    }
}
