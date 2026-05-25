namespace DigitalPensionPlanDomain.Entities
{
    public class Gender
    {
        public required Guid GenderId { get; init; }
        public required string GenderDescription { get; init; }
    }
}