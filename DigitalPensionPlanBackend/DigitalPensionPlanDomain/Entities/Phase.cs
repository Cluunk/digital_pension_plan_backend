using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanDomain.Entities
{
    public class Phase 
    {
        public required Guid PhaseId { get; init; }
        public required string PhaseName { get; init; }
    }
}
