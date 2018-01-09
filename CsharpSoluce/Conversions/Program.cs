using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {

            Auto fiat500 = new Auto();

            Vahicule porsche = new Auto();  // porsche est declaré comme vehicule mais comporte comme auto, donc fait tout comme une autot mais pas une auto : ici paossible car heritage

            ((Auto)porsche).Rouler();                  // on convertit puis on lui dit de rouler, ici ok car une auto est un vehicule, mais peut planter


            Auto a = porsche as Auto;       // auto a est la conversion de porsche en auto, si pas possible a = null ;  on peut alors verifier a avant de l'appeler et aisin ne pas planter


            string s = porsche.ToString();

            Console.WriteLine(s);


            DateTime d = Convert.ToDateTime("11/12/2017");   // convert le string en datetime


          

            if (fiat500 is Auto) Console.WriteLine("Fiat 500 est une auto");
            if (fiat500 is Vahicule) Console.WriteLine("Fiat est vehicule");
       //     if (!(fiat500 is Moto)) Console.WriteLine("fiat n'est pas moto!");




            Console.Read();

        }

        
    }
}
