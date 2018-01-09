using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Calculatrice
    {


        public int Add(int a, int b) { return a + b;   }
        public int Sub(int a, int b) { return a - b; }
        public int Mul(int a, int b) { return a * b; }
        public int Div(int a, int b) { return a / b; }
        
        public double Sinus(double a) { return Math.Sin(a); }

        internal void Moins(ref int a)
        {
            a = -a;     // pas de return mais on change un la ref d'un pointeur donc pas besoin
            
        }


        public int SuiteNum(int n)
        {
            if (n == 1) return 1;
            return n + SuiteNum(n - 1);

        }


        public int SuiteFac(int n)
        {
            if (n == 1) return 1;
            return n + SuiteFac(n - 1);

        }



        public Suiteresulat Suite (int n)       // En gros on fait une classe et un objet de cette classe pour stocker nos variable et ainsi l'appeler depuis programme
        {

            int res1 = SuiteNum(n);
            int res2 = SuiteFac(n);


            var r = new Suiteresulat();     // on mets les variables dans l'objet de la classe et on retourne l'objet contenant les variable

            r.Num = res1;
            r.Fac = res2;

            return r;
            
        }

    }
}
