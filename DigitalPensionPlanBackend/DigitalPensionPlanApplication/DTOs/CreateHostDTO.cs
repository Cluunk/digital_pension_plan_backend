using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.DTOs
{
    public record CreateHostDTO(Guid userRoleId, string HostName, string Password);
}
