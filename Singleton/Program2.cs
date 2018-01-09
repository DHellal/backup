using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program2
    {
        static void Main(string[] args)
        {
            TourEiffel t1 = TourEiffel.Instance;
            TourEiffel t2 = TourEiffel.Instance;
            Console.WriteLine(t1 == t2 ? "Gagné !" : "Perdu");

            NotreDameDeParis ndp1 = new NotreDameDeParis();
            NotreDameDeParis ndp2 = new NotreDameDeParis();
            NotreDameDeParis ndp3 = new NotreDameDeParis();
            NotreDameDeParis ndp4 = new NotreDameDeParis();
            Console.WriteLine(ndp1 == ndp3 ? "Gagné !" : "Perdu");
            Console.WriteLine(ndp2 == ndp4 ? "Gagné !" : "Perdu");

            Console.Read();
        }
    }
    public class TourEiffel
    {
        private static TourEiffel instance = null;

        private TourEiffel() { }

        public static TourEiffel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TourEiffel();
                }
                return instance;
            }
        }
    }
    public class NotreDameDeParis
    {
        private static NotreDameDeParis instance1 = null;
        private static NotreDameDeParis instance2 = null;

        private NotreDameDeParis() { }
        private static int Compteur = 0;
        public static NotreDameDeParis Instance
        {
            get
            {
                if (Compteur == 0) // instance1==null
                {
                    instance1 = new NotreDameDeParis();
                    return instance1;
                }
                if (Compteur == 1) // instance1!= null && instance2==null
                {
                    instance2 = new NotreDameDeParis();
                    return instance2;
                }
                if (Compteur % 2 == 1)
                {
                    return instance1;
                }
                return instance2;
            }
        }
    }
}
