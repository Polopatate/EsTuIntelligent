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
            var json = File.ReadAllText($"C:\\Users\\li25tm\\source\\repos\\CoursDeProgrammation\\CoursDeProgrammation.Data\\Fichiers\\Questions{nomFormate}.json");
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
