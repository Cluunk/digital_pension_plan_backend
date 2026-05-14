using DigitalPensionPlanApplication.UseCases.Genders.GetGender;
using DigitalPensionPlanApplication.UseCases.Genders.GetGenders;
using Microsoft.AspNetCore.Mvc;

namespace DigitalPensionPlanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController(IGetGenderUseCase getGender, IGetGendersUseCase getGenders) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetPhases()
        {
            return Ok(await getGenders.ExecuteAsync());
        }

        [HttpGet("{genderId}")]
        public async Task<IActionResult> GetById(Guid genderId)
        {
            var phase = await getGender.ExecuteAsync(genderId);

            if (phase == null)
                return NotFound();

            return Ok(phase);
        }
    }
}
