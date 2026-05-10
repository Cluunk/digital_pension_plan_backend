using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanDomain.Entities
{
    public record Phase {
        public Guid PhaseId { get; init; }
        public required string PhaseName { get; init; }
    }
}
