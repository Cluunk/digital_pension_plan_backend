using DigitalPensionPlanApplication.DTOs;
using DigitalPensionPlanApplication.UseCases.Phases.GetPhase;
using DigitalPensionPlanDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.UseCases.UserRoles.GetUserRoles
{
    public class GetUserRolesUseCase(IUserRoleRepository userRoleRepository) : IGetUserRolesUseCase
    {
        public async Task<List<UserRoleDTO>> ExecuteAsync()
        {
            var userRoles = await userRoleRepository.GetAllAsync();
            return userRoles.Select(userRole => new UserRoleDTO(userRole.UserRoleId, userRole.UserRoleName)).ToList();
        }
    }
}
