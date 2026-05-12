using DigitalPensionPlanApplication.DTOs;
using DigitalPensionPlanDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.UseCases.Phases.GetPhases
{
    public class GetPhasesUseCase(IPhaseRepository phaseRepository) : IGetPhasesUseCase
    {
        public async Task<List<PhaseDTO>> ExecuteAsync()
        {
            var phases = await phaseRepository.GetAllAsync();
            return phases.Select(phase => new PhaseDTO(phase.PhaseId, phase.PhaseName)).ToList();
        }
    }
}
