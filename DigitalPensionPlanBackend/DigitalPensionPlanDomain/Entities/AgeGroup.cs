namespace DigitalPensionPlanDomain.Entities
{
    public class AgeGroup
    {
        public Guid AgeGroupId { get; private set; }
        public int MinimumAge { get; init; }
        public int MaximumAge { get; init; }
        public string AgeGroupDescription { get; init; } = string.Empty;
    }
}