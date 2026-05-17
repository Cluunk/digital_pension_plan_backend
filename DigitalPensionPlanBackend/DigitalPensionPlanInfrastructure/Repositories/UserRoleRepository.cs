using DigitalPensionPlanDomain.Entities;
using DigitalPensionPlanDomain.Interfaces;
using DigitalPensionPlanInfrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanInfrastructure.Repositories
{
    public class UserRoleRepository(ApplicationDbContext context) : IUserRoleRepository
    {
        public Task<List<UserRole>> GetAllAsync()
        {
            return context.UserRoles.ToListAsync();
        }

        public Task<UserRole?> GetByIdAsync(Guid userRoleId)
        {
            return context.UserRoles.FindAsync(userRoleId).AsTask();
        }
    }
}
