using DigitalPensionPlanApplication.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.UseCases.Phases.GetPhases
{
    public interface IGetPhasesUseCase
    {
        Task<List<PhaseDTO>> ExecuteAsync();
    }
}
