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
    public class DungeonService : IDungeonService
    {
        private readonly IRepository<Dungeon> _dungeonRepository;
        private readonly IMapper _mapper;

        public DungeonService(IRepository<Dungeon> dungeonRepo, IMapper mapper)
        {
            _dungeonRepository = dungeonRepo;
            _mapper = mapper;
        }

        public async Task<DungeonResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _dungeonRepository.GetAllAsync()
                .Include(d => d.DungeonCharacters)
                    .ThenInclude(dc => dc.Character)
                .SingleOrDefaultAsync(d => d.Id.Equals(id));

            var dto = _mapper.Map<DungeonResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<DungeonResponseDto>> ListAllAsync()
        {
            var result = await _dungeonRepository.GetAllAsync()
                .Include(d => d.DungeonCharacters)
                    .ThenInclude(dc => dc.Character)
                .ToListAsync();

            var dto = _mapper.Map<IEnumerable<DungeonResponseDto>>(result);
            return dto;
        }   
    }
}
