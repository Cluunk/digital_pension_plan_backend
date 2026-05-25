using DigitalPensionPlanApplication.DTOs;
using DigitalPensionPlanDomain.Interfaces;

namespace DigitalPensionPlanApplication.UseCases.AgeGroups
{
    public class GetAgeGroupsUseCase(IAgeGroupRepository ageGroupRepository)
    {
        public async Task<List<AgeGroupDTO>> ExecuteAsync()
        {
            var ageGroups = await ageGroupRepository.GetAllAsync();
            return ageGroups.Select(ageGroup => new AgeGroupDTO(ageGroup.AgeGroupId, ageGroup.MinimumAge, ageGroup.MaximumAge, ageGroup.AgeGroupDescription)).ToList();
        }
    }
}
