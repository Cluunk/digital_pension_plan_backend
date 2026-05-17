using DigitalPensionPlanApplication.DTOs;
using DigitalPensionPlanDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.UseCases.UserRoles.GetUserRole
{
    public class GetUserRoleUseCase(IUserRoleRepository userRoleRepository) : IGetUserRoleUseCase
    {
        public async Task<UserRoleDTO?> ExecuteAsync(Guid userRoleId)
        {
            var userRole = await userRoleRepository.GetByIdAsync(userRoleId);

            return userRole != null
                ? new UserRoleDTO(userRole.UserRoleId, userRole.UserRoleName)
                : null;
        }
    }
}
