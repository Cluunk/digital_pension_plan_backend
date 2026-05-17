using DigitalPensionPlanApplication.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPensionPlanApplication.UseCases.UserRoles.GetUserRole
{
    public interface IGetUserRoleUseCase
    {
        Task<UserRoleDTO?> ExecuteAsync(Guid userRoleId);
    }
}
