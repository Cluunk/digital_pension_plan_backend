using DigitalPensionPlanApplication.DTOs;
using DigitalPensionPlanDomain.Interfaces;

namespace DigitalPensionPlanApplication.UseCases.Phases
{
    public class GetPhasesUseCase(IPhaseRepository phaseRepository)
    {
        public async Task<List<PhaseDTO>> ExecuteAsync()
        {
            var phases = await phaseRepository.GetAllAsync();
            return phases.Select(phase => new PhaseDTO(phase.PhaseId, phase.PhaseName)).ToList();
        }
    }
}
