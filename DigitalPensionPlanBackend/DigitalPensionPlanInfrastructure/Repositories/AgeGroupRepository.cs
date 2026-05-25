using DigitalPensionPlanDomain.Entities;
using DigitalPensionPlanDomain.Interfaces;
using DigitalPensionPlanInfrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace DigitalPensionPlanInfrastructure.Repositories
{
    public class AgeGroupRepository(ApplicationDbContext context) : IAgeGroupRepository
    {
        public Task<List<AgeGroup>> GetAllAsync()
        {
            return context.AgeGroups.ToListAsync();
        }

        public Task<AgeGroup?> GetByIdAsync(Guid ageGroupId)
        {
            return context.AgeGroups.FindAsync(ageGroupId).AsTask();
        }
    }
}