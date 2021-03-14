using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly IRepository<Character> _characterRepository;
        private readonly IMapper _mapper;

        public CharacterService(IRepository<Character> characterRepo, IMapper mapper)
        {
            _characterRepository = characterRepo;
            _mapper = mapper;
        }

        public async Task<CharacterResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _characterRepository.GetAllAsync()
                .Include(c => c.ArenaCharacters)
                    .ThenInclude(ac => ac.Arena)
                .Include(c => c.BattlegroundCharacters)
                    .ThenInclude(bc => bc.Battleground)
                .Include(c => c.DungeonCharacters)
                    .ThenInclude(dc => dc.Dungeon)
                .Include(c => c.RaidCharacters)
                    .ThenInclude(rc => rc.Raid)
                .Include(c => c.User)
                .SingleOrDefaultAsync(c => c.Id.Equals(id));

            var dto = _mapper.Map<CharacterResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<CharacterResponseDto>> ListAllAsync()
        {
            var result = await _characterRepository.GetAllAsync()
                .Include(c => c.ArenaCharacters)
                    .ThenInclude(ac => ac.Arena)
                .Include(c => c.BattlegroundCharacters)
                    .ThenInclude(bc => bc.Battleground)
                .Include(c => c.DungeonCharacters)
                    .ThenInclude(dc => dc.Dungeon)
                .Include(c => c.RaidCharacters)
                    .ThenInclude(rc => rc.Raid)
                .Include(c => c.User)
                .ToListAsync();

            var dto = _mapper.Map<IEnumerable<CharacterResponseDto>>(result);
            return dto;
        }
    }
}
