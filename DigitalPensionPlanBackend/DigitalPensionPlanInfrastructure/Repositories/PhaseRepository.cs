using DigitalPensionPlanDomain.Entities;
using DigitalPensionPlanDomain.Interfaces;
using DigitalPensionPlanInfrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanInfrastructure.Repositories
{
    public class PhaseRepository(ApplicationDbContext context) : IPhaseRepository
    {
        public Task<List<Phase>> GetAllAsync()
        {
            return context.Phases.ToListAsync();
        }

        public Task<Phase?> GetByIdAsync(Guid phaseId)
        {
            return context.Phases.FindAsync(phaseId).AsTask();
        }
    }
}
