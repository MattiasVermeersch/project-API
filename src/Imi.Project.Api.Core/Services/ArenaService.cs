using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class ArenaService : IArenaService
    {
        private readonly IArenaRepository _arenaRepository;
        private readonly IMapper _mapper;

        public ArenaService(IArenaRepository arenaRepo, IMapper mapper)
        {
            _arenaRepository = arenaRepo;
            _mapper = mapper;
        }

        public async Task<ArenaResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _arenaRepository.GetByIdAsync(id);

            var dto = _mapper.Map<ArenaResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<ArenaResponseDto>> ListAllAsync()
        {
            var result = await _arenaRepository.ListAllAsync();

            var dto = _mapper.Map<IEnumerable<ArenaResponseDto>>(result);
            return dto;
        }

        public async Task<IEnumerable<ArenaResponseDto>> GetByCharacterId(Guid id)
        {
            var result = await _arenaRepository.GetByCharacterId(id);

            var dto = _mapper.Map<IEnumerable<ArenaResponseDto>>(result);
            return dto;
        }
    }
}
