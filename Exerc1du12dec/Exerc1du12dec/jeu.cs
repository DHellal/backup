using System.Collections.Generic;

namespace Exerc1du12dec
{
    internal class jeu
    {

        public List<piece> SeDeplace(List<piece> pieces, Emplacement initial, Emplacement objectif, Emplacement intermediaire)
        {

            //List<piece> Listefin = new List<piece>();
            //List<piece> Listeinter = new List<piece>();



            //Listeinter = piecesdebut;


            //  objectif.ListesurPieces[0] = piecesdebut[piecesdebut.Count];       // passage 1 vers B

            //  piecesdebut[piecesdebut.Count] = null;      // compte la case ?


            //  intermediaire.ListesurPieces[0] = piecesdebut[piecesdebut.Count - 1];        // passage 2 vers C

            //  piecesdebut[piecesdebut.Count - 1] = null;


            //  intermediaire.ListesurPieces[1] = objectif.ListesurPieces[0];       // passage 1 sur 2 dans C

            //  objectif.ListesurPieces[0] = null;



            //  objectif.ListesurPieces[0] = piecesdebut[piecesdebut.Count - 2];        // passage piece 3 vers B  : sa place finale

            //  piecesdebut[piecesdebut.Count - 2] = null;


            ////  piecesdebut[0] = 


            // correction :


            // on fait une liste pour grandepiece (probleme en bas
            List<piece> listedeunepiece = new List<piece>();



            //etape 1
            //          piece grandePiece = piecesdebut[0];     // on mets la piece 0 dans objet grande piece
            //         piecesdebut.Remove(grandePiece);        // enleve le pointeur de grandepiece dans la liste piecedebut

            listedeunepiece.Add(pieces[0]);        //pareil qu'en haut mais grande piece devient une liste
            pieces.RemoveAt(0);                    // removeat sert à remove en donnant un emplacement
            SeDeplace(pieces, initial, intermediaire, objectif);       // ça switch objectif et inter à chaque fois

            //etape 2

            SeDeplace(listedeunepiece /*anciennement grandepiece */, initial, objectif, intermediaire);       // probleme que grandpiece est pasune liste... on doit faire que àa soit une liste

            // etape 3 :
            SeDeplace(pieces, intermediaire, objectif, initial);



            return objectif.ListesurPieces;
        }


    }
}