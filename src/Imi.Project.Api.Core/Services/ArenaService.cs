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
    public class ArenaService : IArenaService
    {
        private readonly IRepository<Arena> _arenaRepository;
        private readonly IMapper _mapper;

        public ArenaService(IRepository<Arena> arenaRepo, IMapper mapper)
        {
            _arenaRepository = arenaRepo;
            _mapper = mapper;
        }

        public async Task<ArenaResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _arenaRepository.GetAllAsync()
                .Include(a => a.ArenaCharacters)
                    .ThenInclude(ac => ac.Character)
                .SingleOrDefaultAsync(a => a.Id.Equals(id));

            var dto = _mapper.Map<ArenaResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<ArenaResponseDto>> ListAllAsync()
        {
            var result = await _arenaRepository.GetAllAsync()
                .Include(a => a.ArenaCharacters)
                    .ThenInclude(ac => ac.Character)
                .ToListAsync();

            var dto = _mapper.Map<IEnumerable<ArenaResponseDto>>(result);
            return dto;
        }
    }
}
