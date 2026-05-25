namespace DigitalPensionPlanDomain.Entities
{
    public class AgeGroup
    {
        public required Guid AgeGroupId { get; init; }
        public required int MinimumAge { get; init; }
        public required int MaximumAge { get; init; }
        public required string AgeGroupDescription { get; init; }
    }
}