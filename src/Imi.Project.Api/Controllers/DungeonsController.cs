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
    public class DungeonsController : ControllerBase
    {
        private readonly IDungeonService _dungeonService;

        public DungeonsController(IDungeonService dungeonService)
        {
            _dungeonService = dungeonService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dungeons = await _dungeonService.ListAllAsync();

            return Ok(dungeons);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var dungeon = await _dungeonService.GetByIdAsync(id);

            if(dungeon == null)
            {
                return NotFound($"A dungeon with ID {id} could not be found.");
            }

            return Ok(dungeon);
        }
    }
}
