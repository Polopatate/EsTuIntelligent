using System;
using CoursDeProgrammation.Questions;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Runtime;

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

            var json = File.ReadAllText(
                "C:\\Users\\li25tm\\source\\repos\\CoursDeProgrammation\\Questions\\Fichiers\\QuestionsPolo.json");
            var donneesPolo = JsonConvert.DeserializeObject<InformationsSurLaQuestion[]>(json);

            var question1 = donneesPolo.First();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(question1.Question);
            Console.ResetColor();


            foreach (var reponse in question1.Reponses)
            {
                Console.WriteLine(reponse.Identifiant + ") " + reponse.Reponse);
            }
            Console.WriteLine();
            Console.Write("Écrivez votre réponse ici: ");
            string texteSaisi = Console.ReadLine();

            if (texteSaisi == question1.BonneReponse)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("bravo maudit chevreuil t'a eu un point!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("t nul t'as pas de point cheh");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.Write("Appuyer sur enter pour continuer");
            
            var touche = Console.ReadKey();
            while (touche.Key != ConsoleKey.Enter)
            {
                touche = Console.ReadKey();
            }


            Console.WriteLine();
            Console.WriteLine();


            var question2 = donneesPolo.Last();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(question2.Question);
            Console.ResetColor();


            foreach (var reponse in question2.Reponses)
            {
                Console.WriteLine(reponse.Identifiant + ") " + reponse.Reponse);
            }
            Console.WriteLine();
            Console.Write("Écrivez votre réponse ici: ");
            string texteSaisi2 = Console.ReadLine();

            if (texteSaisi2 == question2.BonneReponse)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("t un winner le chevreuil");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("tu connais pas bien les createurs");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.Write("Appuyer sur enter pour continuer");
            while (texteSaisi2 != MotPourSortir)
            {
                texteSaisi2 = Console.ReadLine();
            }


            while (texteSaisi != MotPourSortir)
            {
                texteSaisi = Console.ReadLine();
            }

            Environment.Exit(0);
        }
    }
}
