using BusinessLogicLayer.DTOs.Users;
using BusinessLogicLayer.Interfaces.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apteka.WebApi.Controllers.Users;

[Route("api/user")]
[ApiController]
public class UserController : ControllerBase
{
    private IUserService _userService;

    public UserController(IUserService service)
    {
        _userService = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    => Ok( _userService.GetAll());

    [HttpPost]
    public IActionResult Add(AddUserDto userDto)
    => Ok(_userService.AddUser(userDto));

    [HttpDelete]
    public IActionResult Remove(Guid Id)
    => Ok(_userService.Remove(Id));

    [HttpPut]
    public IActionResult Update(UpdateUserDto userDto, Guid Id)
    => Ok(_userService.Update(userDto, Id));
}
