using DigitalPensionPlanApplication.UseCases.UserRoles.GetUserRole;
using DigitalPensionPlanApplication.UseCases.UserRoles.GetUserRoles;
using Microsoft.AspNetCore.Mvc;

namespace DigitalPensionPlanAPI.Controllers
{
    [Route("api/user/user-role")]
    [ApiController]
    public class UserRoleController(IGetUserRoleUseCase getRole, IGetUserRolesUseCase getRoles) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            return Ok(await getRoles.ExecuteAsync());
        }

        [HttpGet("{roleId}")]
        public async Task<IActionResult> GetById(Guid roleId)
        {
            var role = await getRole.ExecuteAsync(roleId);

            if (role == null)
                return NotFound();

            return Ok(role);
        }
    }
}
