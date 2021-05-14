using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        //SignInManager should be in a Service
        private readonly SignInManager<User> _signInManager;

        public UsersController(IUserService userService, SignInManager<User> signInManager)
        {
            _userService = userService;
            _signInManager = signInManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userService.ListAllAsync();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var user = await _userService.GetByIdAsync(id);

            if(user == null)
            {
                return NotFound($"User with ID {id} could not be found.");
            }

            return Ok(user);
        }

        [AllowAnonymous]
        [HttpPost("api/auth/register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserRequestDto registerUser)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var userResponse = await _userService.AddAsync(registerUser);

            var errorResult = userResponse.Error;

            if(errorResult != null && !errorResult.Succeeded)
            {
                foreach(var error in errorResult.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }

            return Ok(userResponse);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UserRequestDto userRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userResponse = await _userService.UpdateAsync(userRequest);

            return Ok(userResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userService.GetByIdAsync(id);

            if(user == null)
            {
                return NotFound($"User with ID {id} could not be found.");
            }

            await _userService.DeleteAsync(id);
            return Ok();
        }
    }
}
