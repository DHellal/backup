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
                from p1 in listePoints
                from p2 in listePoints
                where string.Compare(p1.Nom, p2.Nom) < 0
                select new Segment
                {
                    Point1 = p1,
                    Point2 = p2,
                    Longueur = Math.Sqrt
                        (
                        Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2)
                        )
                };
            var segmentsCourts = listeSegment
                .Where(s => s.Longueur == listeSegment.Min(t => t.Longueur));       // on prends segments plus petit

            foreach (var seg in segmentsCourts)
                Console.WriteLine(seg);

            Console.Read();
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
        public double Longueur;
        public override string ToString()
        {
            return string.Format("{0}{1} : {2:# ###.0}", Point1.Nom, Point2.Nom, Longueur*1000);        // # ### pour mettre espace 
        }
    }
}
