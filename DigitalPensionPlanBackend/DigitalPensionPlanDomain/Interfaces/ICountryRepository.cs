using DigitalPensionPlanDomain.Entities;

namespace DigitalPensionPlanDomain.Interfaces
{
    public interface ICountryRepository
    {

        Task<List<Country>> GetAllAsync();
        Task<Country?> GetByIdAsync(Guid countryId);
    }
}