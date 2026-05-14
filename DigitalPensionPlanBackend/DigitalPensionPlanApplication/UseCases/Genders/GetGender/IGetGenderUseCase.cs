using DigitalPensionPlanApplication.DTOs;

namespace DigitalPensionPlanApplication.UseCases.Genders.GetGender
{
    public interface IGetGenderUseCase
    {
        Task<GenderDTO?> ExecuteAsync(Guid genderId);
    }
}
