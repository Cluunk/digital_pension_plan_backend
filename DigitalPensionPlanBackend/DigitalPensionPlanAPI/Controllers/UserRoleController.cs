using DigitalPensionPlanApplication.UseCases.UserRoles;
using Microsoft.AspNetCore.Mvc;

namespace DigitalPensionPlanAPI.Controllers
{
    [Route("api/user/user-role")]
    [ApiController]
    public class UserRoleController(GetUserRoleUseCase getRole, GetUserRolesUseCase getRoles) : ControllerBase
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
