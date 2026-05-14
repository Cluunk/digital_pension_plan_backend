using DigitalPensionPlanApplication.DTOs;
using DigitalPensionPlanDomain.Interfaces;

namespace DigitalPensionPlanApplication.UseCases.Genders.GetGender
{
    public class GetGenderUseCase(IGenderRepository genderRepository) : IGetGenderUseCase
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
