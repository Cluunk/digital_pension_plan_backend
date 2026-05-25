using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.DTOs
{
    public record AgeGroupDTO(Guid AgeGroupId, int MinimumAge, int MaximumAge, string AgeGroupDescription);
}
