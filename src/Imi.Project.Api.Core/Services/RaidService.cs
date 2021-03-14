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
    public class RaidService : IRaidService
    {
        private readonly IRepository<Raid> _raidRepository;
        private readonly IMapper _mapper;

        public RaidService(IRepository<Raid> raidRepo, IMapper mapper)
        {
            _raidRepository = raidRepo;
            _mapper = mapper;
        }
        public async Task<RaidResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _raidRepository.GetAllAsync()
                .Include(a => a.RaidCharacters)
                    .ThenInclude(ac => ac.Character)
                .SingleOrDefaultAsync(a => a.Id.Equals(id));

            var dto = _mapper.Map<RaidResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<RaidResponseDto>> ListAllAsync()
        {
            var result = await _raidRepository.GetAllAsync()
                .Include(a => a.RaidCharacters)
                    .ThenInclude(ac => ac.Character)
                .ToListAsync();

            var dto = _mapper.Map<IEnumerable<RaidResponseDto>>(result);
            return dto;
        }
    }
}
