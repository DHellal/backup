using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Piece> pieces = new List<Piece> {
                new Piece { Nom = "piece2€", taille=3  },
                new Piece { Nom = "piece1€", taille=2  },
                new Piece { Nom = "piece20c", taille=1  },
            };
            List<Emplacement> places = new List<Emplacement> {
                new Emplacement {Nom="A" },
                new Emplacement {Nom="B" },
                new Emplacement {Nom="C" }
            };
            places[0].Pieces = pieces; // La pile de pièces est posé à l'emplacement A

            Jeu j = new Jeu();
            // Déplacer la pile de pièces de A vers B en prenant C comme intermédiaire
            j.Deplacer(pieces, places[0], places[1], places[2]);

            Console.Read();
        }
    }
    class Piece
    {
        public int taille;
        public string Nom;
        public override string ToString()
        {
            return taille.ToString();
        }
    }
    class Emplacement
    {
        public string Nom;
        public List<Piece> Pieces = new List<Piece>();
        public override string ToString()
        {
            return Nom;
        }
    }
    class Jeu
    {
        public void Deplacer(List<Piece> pieces, Emplacement initial, Emplacement objectif, Emplacement intermediaire)
        {
            if (pieces.Count == 1)
            {
                Console.WriteLine("{0}{1}{2}", pieces[0].taille, initial.Nom, objectif.Nom);
                objectif.Pieces.Add(pieces[0]);
                initial.Pieces.Remove(pieces[0]);
            }
            else
            {
                List<Piece> listeDeUnePiece = new List<Piece>();

                // Etape 1
                listeDeUnePiece.Add(pieces[0]);
                pieces.RemoveAt(0);
                Deplacer(pieces, initial, intermediaire, objectif);

                // Etape 2
                Deplacer(listeDeUnePiece, initial, objectif, intermediaire);

                // Etape 3
                Deplacer(pieces, intermediaire, objectif, initial);
            }
        }

    }
}
