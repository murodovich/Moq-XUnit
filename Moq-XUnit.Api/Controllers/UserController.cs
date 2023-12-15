using Microsoft.AspNetCore.Mvc;
using Moq_XUnit.Application.UserServices;
using Moq_XUnit.Domain.Dtos;

namespace Moq_XUnit.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var result = await _userService.UserGetAllAsync();
            return Ok(result);
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(UserDto userDto)
        {
            var result = await _userService.UserCreateAsync(userDto);
            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int id)
        {
            var result = await _userService.UserGetByIdAsync(id);
            return Ok(result);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync(int Id,UserDto userDto)
        {
            var result = await _userService.UserUpdateAsync(Id, userDto);
            return Ok(result);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            var result = await _userService.UserDeleteAsync(id);
            return Ok(result);
        }
    }
}
