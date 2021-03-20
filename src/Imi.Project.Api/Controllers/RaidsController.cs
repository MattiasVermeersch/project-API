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
    public class RaidsController : ControllerBase
    {
        private readonly IRaidService _raidService;
        
        public RaidsController(IRaidService raidService)
        {
            _raidService = raidService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var raids = await _raidService.ListAllAsync();

            return Ok(raids);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var raid = await _raidService.GetByIdAsync(id);

            if(raid == null)
            {
                return NotFound($"Raid with ID {id} could not be found.");
            }

            return Ok(raid);
        }
    }
}
