using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> listePoints = new List<Point> {
                new Point { Nom="A", X=1, Y=0 },
                new Point { Nom="B", X=2, Y=5 },
                new Point { Nom="C", X=3, Y=3 },
                new Point { Nom="D", X=5, Y=1 },
                new Point { Nom="E", X=6, Y=3 }
            };
            var listeSegment =
                from p1 in listePoints      // pour chaque un p1 dans la liste de points
                from p2 in listePoints      // et un autre p2
                where string.Compare(p1.Nom, p2.Nom) < 0        // on prends que quand le point est superieur (pour eviter doublon)
                select new Segment { Point1 = p1, Point2 = p2 }; // on fait un segment p1 p2
        }
    }
    class Point
    {
        public string Nom;
        public int X;
        public int Y;
        public override string ToString()
        {
            return Nom;
        }
    }
    class Segment
    {
        public Point Point1;
        public Point Point2;
        public int Longueur;
        public override string ToString()
        {
            return Point1.Nom + Point2.Nom;
        }
    }
}
