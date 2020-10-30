using System.Collections.Generic;
using CoursDeProgrammation.DomainObjects;

namespace CoursDeProgrammation.Data
{
    public interface IQuestionRepository
    {
        IEnumerable<InformationsSurLaQuestion> ObtenirInformationsSurLaquestion(string nom);
    }
}
