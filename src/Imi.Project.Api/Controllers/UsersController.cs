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
        public async Task<IActionResult> Get(Guid id)
        {
            var user = await _userService.GetByIdAsync(id);

            if(user == null)
            {
                return NotFound($"User with ID {id} could not be found.");
            }

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Post(UserRequestDto userRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userResponseDto = await _userService.AddAsync(userRequestDto);
            return CreatedAtAction(nameof(Get), new { id = userResponseDto.Id }, userResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UserRequestDto userRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userResponseDto = await _userService.UpdateAsync(userRequestDto);

            return Ok(userResponseDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
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
