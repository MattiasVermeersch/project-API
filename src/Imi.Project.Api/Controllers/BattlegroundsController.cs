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
    public class BattlegroundsController : ControllerBase
    {
        private readonly IBattlegroundService _battlegroundService;
        public BattlegroundsController(IBattlegroundService battlegroundService)
        {
            _battlegroundService = battlegroundService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var battleGrounds = await _battlegroundService.ListAllAsync();

            return Ok(battleGrounds);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var battleGround = await _battlegroundService.GetByIdAsync(id);

            if(battleGround == null)
            {
                return NotFound($"Battleground with ID {id} could not be found.");
            }

            return Ok(battleGround);
        }
    }
}
