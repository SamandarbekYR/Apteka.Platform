using BusinessLogicLayer.DTOs.Users;
using BusinessLogicLayer.Interfaces.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apteka.WebApi.Controllers.Users
{
    [Route("api/user-role")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private IUserRoleService _userRoleSet;

        public UserRoleController(IUserRoleService userRole)
        {
            _userRoleSet = userRole;
        }
        [HttpGet]
        public IActionResult GetAll()
        => Ok( _userRoleSet.GetAll());

        [HttpPost]
        public IActionResult Add(AddUserRoleDto dto)
        {
            _userRoleSet.Add(dto);

            return Ok();
        }

        [HttpPut]
        public IActionResult Update(AddUserRoleDto userDto, Guid Id)
        {
            _userRoleSet.Update(userDto, Id);

            return Ok();
        }
    }
}
