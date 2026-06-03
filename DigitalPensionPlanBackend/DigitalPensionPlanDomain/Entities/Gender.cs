namespace DigitalPensionPlanDomain.Entities
{
    public class Gender
    {
        public Guid GenderId { get; private set; }
        public string GenderDescription { get; init; } = string.Empty;
    }
}