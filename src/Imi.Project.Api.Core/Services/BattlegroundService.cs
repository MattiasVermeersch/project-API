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
    public class BattlegroundService : IBattlegroundService
    {
        private readonly IRepository<Battleground> _battlegroundRepository;
        private readonly IMapper _mapper;

        public BattlegroundService(IRepository<Battleground> battlegroundRepo, IMapper mapper)
        {
            _battlegroundRepository = battlegroundRepo;
            _mapper = mapper;
        }

        public async Task<BattlegroundResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _battlegroundRepository.GetAllAsync()
                .Include(b => b.BattlegroundCharacters)
                    .ThenInclude(bc => bc.Character)
                .SingleOrDefaultAsync(b => b.Id.Equals(id));

            var dto = _mapper.Map<BattlegroundResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<BattlegroundResponseDto>> ListAllAsync()
        {
            var result = await _battlegroundRepository.GetAllAsync()
                .Include(b => b.BattlegroundCharacters)
                    .ThenInclude(bc => bc.Character)
                .ToListAsync();

            var dto = _mapper.Map<IEnumerable<BattlegroundResponseDto>>(result);
            return dto;
        }
    }
}
