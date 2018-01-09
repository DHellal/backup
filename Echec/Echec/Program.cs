using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echiquier
{
    class Program
    {
        static void Main(string[] args)
        {
            Echiquier echiquier = new Echiquier();
            Cavalier cavalier = new Cavalier(echiquier, "A1");
        }
    }
    class Echiquier
    {
        public Echiquier()
        {
            //Cases[0, 0] = new Case { Nom = "A1" };
            //Cases[0, 1] = new Case { Nom = "B1" };
            //Cases[0, 2] = new Case { Nom = "C1" };
            //Cases[0, 3] = new Case { Nom = "D1" };
            //Cases[0, 4] = new Case { Nom = "E1" };
            //Cases[0, 5] = new Case { Nom = "F1" };
            //Cases[0, 6] = new Case { Nom = "G1" };
            //Cases[0, 7] = new Case { Nom = "H1" };
            //Cases[1, 0] = new Case { Nom = "A2" };
            //Cases[1, 1] = new Case { Nom = "B2" };
            //Cases[1, 2] = new Case { Nom = "C2" };
            //Cases[1, 3] = new Case { Nom = "D2" };
            //Cases[1, 4] = new Case { Nom = "E2" };
            //Cases[1, 5] = new Case { Nom = "F2" };
            //Cases[1, 6] = new Case { Nom = "G2" };
            //Cases[1, 7] = new Case { Nom = "H2" };
            //Cases[2, 0] = new Case { Nom = "A3" };
            //Cases[2, 1] = new Case { Nom = "B3" };
            //Cases[2, 2] = new Case { Nom = "C3" };
            //Cases[2, 3] = new Case { Nom = "D3" };
            //Cases[2, 4] = new Case { Nom = "E3" };
            //Cases[2, 5] = new Case { Nom = "F3" };
            //Cases[2, 6] = new Case { Nom = "G3" };
            //Cases[2, 7] = new Case { Nom = "H3" };
            //Cases[3, 0] = new Case { Nom = "A4" };
            //Cases[3, 1] = new Case { Nom = "B4" };
            //Cases[3, 2] = new Case { Nom = "C4" };
            //Cases[3, 3] = new Case { Nom = "D4" };
            //Cases[3, 4] = new Case { Nom = "E4" };
            //Cases[3, 5] = new Case { Nom = "F4" };
            //Cases[3, 6] = new Case { Nom = "G4" };
            //Cases[3, 7] = new Case { Nom = "H4" };
            //Cases[4, 0] = new Case { Nom = "A5" };
            //Cases[4, 1] = new Case { Nom = "B5" };
            //Cases[4, 2] = new Case { Nom = "C5" };
            //Cases[4, 3] = new Case { Nom = "D5" };
            //Cases[4, 4] = new Case { Nom = "E5" };
            //Cases[4, 5] = new Case { Nom = "F5" };
            //Cases[4, 6] = new Case { Nom = "G5" };
            //Cases[4, 7] = new Case { Nom = "H5" };
            //Cases[5, 0] = new Case { Nom = "A6" };
            //Cases[5, 1] = new Case { Nom = "B6" };
            //Cases[5, 2] = new Case { Nom = "C6" };
            //Cases[5, 3] = new Case { Nom = "D6" };
            //Cases[5, 4] = new Case { Nom = "E6" };
            //Cases[5, 5] = new Case { Nom = "F6" };
            //Cases[5, 6] = new Case { Nom = "G6" };
            //Cases[5, 7] = new Case { Nom = "H6" };
            //Cases[6, 0] = new Case { Nom = "A7" };
            //Cases[6, 1] = new Case { Nom = "B7" };
            //Cases[6, 2] = new Case { Nom = "C7" };
            //Cases[6, 3] = new Case { Nom = "D7" };
            //Cases[6, 4] = new Case { Nom = "E7" };
            //Cases[6, 5] = new Case { Nom = "F7" };
            //Cases[6, 6] = new Case { Nom = "G7" };
            //Cases[6, 7] = new Case { Nom = "H7" };
            //Cases[7, 0] = new Case { Nom = "A8" };
            //Cases[7, 1] = new Case { Nom = "B8" };
            //Cases[7, 2] = new Case { Nom = "C8" };
            //Cases[7, 3] = new Case { Nom = "D8" };
            //Cases[7, 4] = new Case { Nom = "E8" };
            //Cases[7, 5] = new Case { Nom = "F8" };
            //Cases[7, 6] = new Case { Nom = "G8" };
            //Cases[7, 7] = new Case { Nom = "H8" };
        }
        internal bool Deplace(Piece piece, Point decalage)
        {
            char posX = (char)(piece.Emplacement[0] + decalage.x);
            int posY= int.Parse(piece.Emplacement[1].ToString());
            if (posX < 65 || posX > 72 || posY < 0 || posY > 8) return false;
            piece.Emplacement = posX.ToString() + posY.ToString();
            return true;          
        }
    }

    class Cavalier : Piece
    {
        private Random Alea = new Random();
        private Point[] DeplacementsPossibles = new Point[8];
        private Echiquier Echiquier = null;
        public Cavalier(Echiquier ech, string positionInitiale )
        {
            DeplacementsPossibles[0] = new Point { x = -1, y = 2 };
            DeplacementsPossibles[1] = new Point { x = 1, y = 2 };
            DeplacementsPossibles[2] = new Point { x = 2, y = 1 };
            DeplacementsPossibles[3] = new Point { x = 2, y = -1 };
            DeplacementsPossibles[4] = new Point { x = 1, y = -2 };
            DeplacementsPossibles[5] = new Point { x = -1, y = -2 };
            DeplacementsPossibles[6] = new Point { x = -2, y = -1 };
            DeplacementsPossibles[7] = new Point { x = -2, y = 1 };

            Echiquier = ech;
            Emplacement = positionInitiale;
        }
        public void DeplacerAlea()
        {
            // 1. Générer un nombre entre 1 et 8
            int n = 0;
            do
            {
                n = Alea.Next(1, 9);
            }
            while (!Echiquier.Deplace(this, DeplacementsPossibles[n]));

        }
    }
    struct Point
    {
        public int x;
        public int y;
    }
    class Piece
    {
        public string Emplacement = null;
    }
}
