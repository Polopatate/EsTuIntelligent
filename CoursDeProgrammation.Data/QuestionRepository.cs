using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CoursDeProgrammation.DomainObjects;
using Newtonsoft.Json;

namespace CoursDeProgrammation.Data
{
    public class QuestionRepository : IQuestionRepository
    {
        public IEnumerable<InformationsSurLaQuestion> ObtenirInformationsSurLaquestion(string nom)
        {
            var nomFormate = FirstCharToUpper(nom);
            var repertoireExecution = Directory.GetCurrentDirectory();
            var fichier = Path.Combine(repertoireExecution, $"Fichiers\\Questions{nomFormate}.json");
            var json = File.ReadAllText(fichier);
            return JsonConvert.DeserializeObject<InformationsSurLaQuestion[]>(json);
        }

        public static string FirstCharToUpper(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH! mets du texte!!!");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }
    }
}
