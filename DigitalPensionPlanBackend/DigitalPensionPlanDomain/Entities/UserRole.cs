using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanDomain.Entities
{
    public class UserRole
    {
        public required Guid UserRoleId { get; init; }
        public required string UserRoleName { get; init; }
    }
}
