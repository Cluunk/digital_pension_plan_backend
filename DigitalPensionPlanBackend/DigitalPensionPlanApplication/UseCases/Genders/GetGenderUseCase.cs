using DigitalPensionPlanApplication.DTOs;
using DigitalPensionPlanDomain.Interfaces;

namespace DigitalPensionPlanApplication.UseCases.Genders
{
    public class GetGenderUseCase(IGenderRepository genderRepository)
    {
        public async Task<GenderDTO?> ExecuteAsync(Guid genderId)
        {
            var gender = await genderRepository.GetByIdAsync(genderId);

            return gender != null
                ? new GenderDTO(gender.GenderId, gender.GenderDescription)
                : null;
        }
    }
}
