using DigitalPensionPlanApplication.UseCases.AgeGroups;
using Microsoft.AspNetCore.Mvc;

namespace DigitalPensionPlanAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AgeGroupController(GetAgeGroupUseCase getAgeGroup, GetAgeGroupsUseCase getAgeGroups) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAgeGroups()
        {
            return Ok(await getAgeGroups.ExecuteAsync());
        }

        [HttpGet("{ageGroupId}")]
        public async Task<IActionResult> GetById(Guid ageGroupId)
        {
            var ageGroup = await getAgeGroup.ExecuteAsync(ageGroupId);

            if (ageGroup == null)
                return NotFound();

            return Ok(ageGroup);
        }
    }
}
