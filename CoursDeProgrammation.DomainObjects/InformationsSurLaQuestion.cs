namespace CoursDeProgrammation.DomainObjects
{
    public class InformationsSurLaQuestion
    {
        public string Question { get; set; }
        public ReponseInfo[] Reponses { get; set; }
        public string BonneReponse { get; set; }
    }
}
