using DigitalPensionPlanApplication.DTOs;
using DigitalPensionPlanDomain.Interfaces;

namespace DigitalPensionPlanApplication.UseCases.AgeGroups
{
    public class GetAgeGroupUseCase(IAgeGroupRepository ageGroupRepository)
    {
        public async Task<AgeGroupDTO?> ExecuteAsync(Guid ageGroupId)
        {

            var ageGroup = await ageGroupRepository.GetByIdAsync(ageGroupId);

            return ageGroup != null
                ? new AgeGroupDTO(ageGroup.AgeGroupId, ageGroup.MinimumAge, ageGroup.MaximumAge, ageGroup.AgeGroupDescription)
                : null;
        }
    }
}
