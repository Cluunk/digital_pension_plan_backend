using DigitalPensionPlanApplication.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.UseCases.UserRoles.GetUserRoles
{
    public interface IGetUserRolesUseCase
    {
        Task<List<UserRoleDTO>> ExecuteAsync();
    }
}
