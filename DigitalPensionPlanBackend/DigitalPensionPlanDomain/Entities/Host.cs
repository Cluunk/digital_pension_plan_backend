using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanDomain.Entities
{
    public class Host
    {
        public Guid HostId { get; private set; }
        public Guid UserRoleId { get; private set; }
        public string HostName { get; private set; } = string.Empty;
        public string PasswordHash { get; private set; } = string.Empty;

        public void Update(Guid userRoleId, string hostName)
        {
            UserRoleId = userRoleId;
            HostName = hostName;
        }
    }
}
