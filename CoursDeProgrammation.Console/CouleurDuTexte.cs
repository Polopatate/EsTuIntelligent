using System;

namespace CoursDeProgrammation.Caca
{
    public class CouleurDuTexte
    {
       public void EcrireEnCouleur(ConsoleColor couleur, string texte)
        {
            Console.ForegroundColor = couleur;
            Console.WriteLine(texte);
            Console.ResetColor();
        }
    }
} 
