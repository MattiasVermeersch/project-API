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
    public class CharactersController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        private readonly IArenaService _arenaService;
        private readonly IBattlegroundService _battlegroundService;
        private readonly IDungeonService _dungeonService;
        private readonly IRaidService _raidService;

        public CharactersController(ICharacterService characterService,
            IArenaService arenaService, IBattlegroundService battlegroundService,
            IDungeonService dungeonService, IRaidService raidService)
        {
            _characterService = characterService;
            _arenaService = arenaService;
            _battlegroundService = battlegroundService;
            _dungeonService = dungeonService;
            _raidService = raidService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var characters = await _characterService.ListAllAsync();

            return Ok(characters);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var character = await _characterService.GetByIdAsync(id);

            if(character == null)
            {
                return NotFound($"No character with ID {id} could be found.");
            }

            return Ok(character);
        }
    }
}
