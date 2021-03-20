using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class BattlegroundService : IBattlegroundService
    {
        private readonly IBattlegroundRepository _battlegroundRepository;
        private readonly IMapper _mapper;

        public BattlegroundService(IBattlegroundRepository battlegroundRepo, IMapper mapper)
        {
            _battlegroundRepository = battlegroundRepo;
            _mapper = mapper;
        }

        public async Task<BattlegroundResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _battlegroundRepository.GetByIdAsync(id);

            var dto = _mapper.Map<BattlegroundResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<BattlegroundResponseDto>> ListAllAsync()
        {
            var result = await _battlegroundRepository.ListAllAsync();

            var dto = _mapper.Map<IEnumerable<BattlegroundResponseDto>>(result);
            return dto;
        }
    }
}
