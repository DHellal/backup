using System; // pour pouvoir utiliser console

class Maison
{
    public string Couleur = "Bleu";
    public int NbrPorte = 5; // Si on mets rien , apr default c'est 0
    public void Rechauffer() // ici c'est methiode et donc action à faire : void return rien ; 
    {

        Console.WriteLine("La maison chauffe.");

    }

    private int code;

}

public class ProgrammeDenis
{
    public static void Main()

    {
        Maison ResidencePrincipale;  // Declaration = mets dans la table des symboles
        ResidencePrincipale = new Maison();  // Construction (instanciation) = mets reserve l'espace (new) , ensuite l'initialisation permet d'attribuer un nombre ou une valeur

        Maison ResidenceSecondaire = new Maison();   // Declaration de l'objet ResidenceSecondaire ayant la classe Maison et construction de l'objet  ; la declaration mets le nom dans la table des symboles
        ResidenceSecondaire.Couleur = "verte";  // Dit que en fait couleur c'est verte et pas bleue
        ResidenceSecondaire.NbrPorte = 6;

        Voiture Porshe = new Voiture();
        Porshe.NbrPorte = 2;


        Console.WriteLine("La résidence secondaire est de couleur {0} et de nombre de porte {1} ."   // On remarque que console est une classe (classe dans system)
                                                     , ResidenceSecondaire.Couleur, ResidenceSecondaire.NbrPorte); // numerotation commence par 0

        ResidencePrincipale.Rechauffer(); // On demande à la residence principale de faire la methode chauffe


        Console.Read(); // Attends reponse clavier

    }

}


public class Voiture
{

    public string Moteur;
    public int NbrPorte;



}