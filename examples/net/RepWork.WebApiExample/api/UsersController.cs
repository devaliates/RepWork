using Microsoft.AspNetCore.Mvc;

using RepWork.ServiceLayerExample.Abstract;
using RepWork.ServiceLayerExample.Dtos;

namespace RepWork.WebApiExample.api;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService userService;

    public UsersController(IUserService userService)
    {
        this.userService = userService;
    }

    // POST api/<UsersController>
    [HttpPost]
    public async Task Post([FromBody] AddUserDto value)
    {
        await this.userService.Add(value);
    }
}