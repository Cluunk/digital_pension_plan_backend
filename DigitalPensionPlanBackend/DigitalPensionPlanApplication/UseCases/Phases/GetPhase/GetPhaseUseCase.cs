using DigitalPensionPlanApplication.DTOs;
using DigitalPensionPlanDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.UseCases.Phases.GetPhase
{
    public class GetPhaseUseCase(IPhaseRepository phaseRepository) : IGetPhaseUseCase
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
