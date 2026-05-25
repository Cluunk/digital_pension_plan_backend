using Microsoft.AspNetCore.Mvc;
using DigitalPensionPlanApplication.UseCases.Phases;

namespace DigitalPensionPlanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhaseController(GetPhaseUseCase getPhase, GetPhasesUseCase getPhases) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetPhases()
        {
            return Ok(await getPhases.ExecuteAsync());
        }

        [HttpGet("{phaseId}")]
        public async Task<IActionResult> GetById(Guid phaseId)
        {
            var phase = await getPhase.ExecuteAsync(phaseId);

            if (phase == null)
                return NotFound();

            return Ok(phase);
        }
    }
}
