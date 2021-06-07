﻿using Imi.Project.Api.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IArenaService
    {
        Task<IEnumerable<ArenaResponseDto>> ListAllAsync();
        Task<ArenaResponseDto> GetByIdAsync(Guid id);
        Task<IEnumerable<ArenaResponseDto>> GetByCharacterId(Guid id);
        Task<ArenaResponseDto> AddAsync(ArenaRequestDto arenaRequestDto);
        Task<ArenaResponseDto> UpdateAsync(ArenaRequestDto arenaRequestDto);
        Task DeleteAsync(Guid id);
        Task<ArenaResponseDto> AddCharacterAsync(Guid id, CharacterRequestDto characterRequest);
        Task<ArenaResponseDto> DeleteCharacterAsync(Guid arenaId, Guid characterId);
    }
}
