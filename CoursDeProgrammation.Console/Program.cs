using System;
using System.Linq;
using CoursDeProgrammation.Data;
using CoursDeProgrammation.Caca;

namespace CoursDeProgrammation
{
    internal class Program
    {
        private const string MotPourSortir = "fin";

        static void Main()
        {
            Console.WriteLine("Bonjour! Bienvenue dans notre Jeux questionnaire.");
            Console.WriteLine("Répondez à toutes les question et obtenez votre score.");
            Console.WriteLine("Pour quitter le programme, tapez le mot «fin».");
            Console.WriteLine();

            var repo = new QuestionRepository();
            var donnees = repo.ObtenirInformationsSurLaquestion("Polo").ToList();
            var colorieuse = new CouleurDuTexte();

            // question 1 #########################################################################################
            string texteSaisi = string.Empty;

            //var question1 = donnees.First();
            foreach (var question in donnees)
            {
                colorieuse.EcrireEnCouleur(ConsoleColor.Cyan, question.Question);

                foreach (var reponse in question.Reponses)
                {
                    Console.WriteLine(reponse.Identifiant + ") " + reponse.Reponse);
                }
                
                colorieuse.EcrireEnCouleur(ConsoleColor.White, "Écrivez votre réponse ici: ");
                texteSaisi = Console.ReadLine();
                
                if (texteSaisi == question.BonneReponse)
                {
                    colorieuse.EcrireEnCouleur(ConsoleColor.Green, "bravo maudit chevreuil t'a eu un point!");
                }
                else
                {
                    colorieuse.EcrireEnCouleur(ConsoleColor.DarkRed, "t nul t'as pas de point cheh");
                }
                Console.WriteLine();
                Console.Write("Appuyer sur enter pour continuer");

                var touche = Console.ReadKey();
                while (touche.Key != ConsoleKey.Enter)
                {
                    touche = Console.ReadKey();
                }

                Console.WriteLine();
            }
            
            Console.WriteLine();


            while (texteSaisi != MotPourSortir)
            {
                texteSaisi = Console.ReadLine();
            }

            Environment.Exit(0);
        }
    }
}
