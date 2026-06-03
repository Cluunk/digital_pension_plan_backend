using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanDomain.Entities
{
    public class UserRole
    {
        public Guid UserRoleId { get; private set; }
        public string UserRoleName { get; init; } = string.Empty;
    }
}
