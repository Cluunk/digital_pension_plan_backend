using DigitalPensionPlanApplication.DTOs;

namespace DigitalPensionPlanApplication.UseCases.Genders.GetGenders
{
    public interface IGetGendersUseCase
    {
        Task<List<GenderDTO>> ExecuteAsync();
    }
}
