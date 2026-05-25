using DigitalPensionPlanDomain.Entities;

namespace DigitalPensionPlanDomain.Interfaces
{
    public interface IAgeGroupRepository
    {
        Task<List<AgeGroup>> GetAllAsync();
        Task<AgeGroup?> GetByIdAsync(Guid ageGroupId);
    }
}