using DigitalPensionPlanApplication.DTOs;
using DigitalPensionPlanDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.UseCases.UserRoles
{
    public class GetUserRolesUseCase(IUserRoleRepository userRoleRepository)
    {
        public async Task<List<UserRoleDTO>> ExecuteAsync()
        {
            var userRoles = await userRoleRepository.GetAllAsync();
            return userRoles.Select(userRole => new UserRoleDTO(userRole.UserRoleId, userRole.UserRoleName)).ToList();
        }
    }
}
