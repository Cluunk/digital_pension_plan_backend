using DigitalPensionPlanDomain.Entities;

namespace DigitalPensionPlanDomain.Interfaces
{
    public interface IGenderRepository
    {
        Task<List<Gender>> GetAllAsync();
        Task<Gender?> GetByIdAsync(Guid genderId);
    }
}