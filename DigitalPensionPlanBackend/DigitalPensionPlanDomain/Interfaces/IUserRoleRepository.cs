using DigitalPensionPlanDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanDomain.Interfaces
{
    public interface IUserRoleRepository
    {

        Task<List<UserRole>> GetAllAsync();
        Task<UserRole?> GetByIdAsync(Guid userRoleId);
    }
}
