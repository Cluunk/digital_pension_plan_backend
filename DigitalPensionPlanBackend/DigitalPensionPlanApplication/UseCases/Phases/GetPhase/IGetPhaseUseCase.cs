using DigitalPensionPlanApplication.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.UseCases.Phases.GetPhase
{
    public interface IGetPhaseUseCase
    {
        Task<PhaseDTO?> ExecuteAsync(Guid phaseId);
    }
}
