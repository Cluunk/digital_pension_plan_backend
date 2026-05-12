using DigitalPensionPlanApplication.UseCases.Phases.GetPhases;
using DigitalPensionPlanApplication.UseCases.Phases.GetPhase;
using Microsoft.AspNetCore.Mvc;

namespace DigitalPensionPlanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhaseController(IGetPhaseUseCase getPhase, IGetPhasesUseCase getPhases) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetPhases()
        {
            return Ok(await getPhases.ExecuteAsync());
        }

        [HttpGet("{phaseId}")]
        public async Task<IActionResult> GetById(Guid phaseId)
        {
            var item = await getPhase.ExecuteAsync(phaseId);

            if (item == null)
                return NotFound();

            return Ok(item);
        }
    }
}
