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
    public class ArenasController : ControllerBase
    {
        private readonly IArenaService _arenaService;
        public ArenasController(IArenaService arenaService)
        {
            _arenaService = arenaService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var arenas = await _arenaService.ListAllAsync();

            return Ok(arenas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var arena = await _arenaService.GetByIdAsync(id);

            if(arena == null)
            {
                return NotFound($"Arena with ID {id} could not be found.");
            }

            return Ok(arena);
        }
    }
}
