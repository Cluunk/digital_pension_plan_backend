using DigitalPensionPlanApplication.DTOs;
using DigitalPensionPlanDomain.Interfaces;

namespace DigitalPensionPlanApplication.UseCases.Phases
{
    public class GetPhaseUseCase(IPhaseRepository phaseRepository)
    {
        public async Task<PhaseDTO?> ExecuteAsync(Guid phaseId)
        {
            var phase = await phaseRepository.GetByIdAsync(phaseId);

            return phase != null
                ? new PhaseDTO(phase.PhaseId, phase.PhaseName) 
                : null;
        }
    }
}
