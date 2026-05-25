using DigitalPensionPlanDomain.Entities;
using DigitalPensionPlanDomain.Interfaces;
using DigitalPensionPlanInfrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace DigitalPensionPlanInfrastructure.Repositories
{
    public class CountryRepository(ApplicationDbContext context) : ICountryRepository
    {
        public Task<List<Country>> GetAllAsync()
        {
            return context.Countries.ToListAsync();
        }

        public Task<Country?> GetByIdAsync(Guid countryId)
        {
            return context.Countries.FindAsync(countryId).AsTask();
        }
    }
}