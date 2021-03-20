using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class RaidService : IRaidService
    {
        private readonly IRaidRepository _raidRepository;
        private readonly IMapper _mapper;

        public RaidService(IRaidRepository raidRepo, IMapper mapper)
        {
            _raidRepository = raidRepo;
            _mapper = mapper;
        }
        public async Task<RaidResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _raidRepository.GetByIdAsync(id);

            var dto = _mapper.Map<RaidResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<RaidResponseDto>> ListAllAsync()
        {
            var result = await _raidRepository.ListAllAsync();

            var dto = _mapper.Map<IEnumerable<RaidResponseDto>>(result);
            return dto;
        }
    }
}
