using DigitalPensionPlanDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanDomain.Interfaces
{
    public interface IPhaseRepository
    {
        Task<List<Phase>> GetAllAsync();
        Task<Phase?> GetByIdAsync(Guid phaseId);
    }
}
