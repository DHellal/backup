using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program1
    {
        static void Main(string[] args)
        {


            TourEiffel t1 = TourEiffel.instanciation;
            TourEiffel t2 = TourEiffel.instanciation;
            Console.WriteLine(t1 == t2 ? "Gagné !" : "Perdu");
            Console.Read();




            NotreDameDeParis ndp1 = new NotreDameDeParis();
            NotreDameDeParis ndp2 = new NotreDameDeParis





        }
    }

    internal class NotreDameDeParis
    {

        private NotreDameDeParis() { }

        private static NotreDameDeParis instance;

        public static NotreDameDeParis instanciation
        {

            get
            {

                if (instance == null)
                {

                    instance = new NotreDameDeParis();

                }





                return instance;
            }






        }





    }






    class TourEiffel
    {

        private static TourEiffel instance;     // protege car privee, et egale aà null



        private TourEiffel() { }    // instanceur privée et donc pas possible d'instancier

        public static TourEiffel instanciation
        {

            get
            {

                if (instance == null)
                {

                    instance = new TourEiffel();        // instance n'est plus nulle



                }


                return instance;        // meme si on redemande on recup la meme instance

            }


        }






    }
}
