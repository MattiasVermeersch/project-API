using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
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

        public UsersController(IUserService userService)
        {
            _userService = userService;
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

        [HttpPost]
        public async Task<IActionResult> Post(UserRequestDto userRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userResponse = await _userService.AddAsync(userRequest);
            return CreatedAtAction(nameof(Get), new { id = userResponse.Id }, userResponse);
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
