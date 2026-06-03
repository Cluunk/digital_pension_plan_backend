using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanDomain.Entities
{
    public class Phase 
    {
        public Guid PhaseId { get; private set; }
        public string PhaseName { get; init; } = string.Empty;
    }
}
