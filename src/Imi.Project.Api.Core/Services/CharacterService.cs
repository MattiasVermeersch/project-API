using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly IMapper _mapper;

        public CharacterService(ICharacterRepository characterRepo, IMapper mapper)
        {
            _characterRepository = characterRepo;
            _mapper = mapper;
        }

        public async Task<CharacterResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _characterRepository.GetByIdAsync(id);

            var dto = _mapper.Map<CharacterResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<CharacterResponseDto>> ListAllAsync()
        {
            var result = await _characterRepository.ListAllAsync();

            var dto = _mapper.Map<IEnumerable<CharacterResponseDto>>(result);
            return dto;
        }

        public async Task<CharacterResponseDto> AddAsync(CharacterRequestDto characterRequest)
        {
            var character = _mapper.Map<Character>(characterRequest);
            var result = await _characterRepository.AddAsync(character);
            var dto = _mapper.Map<CharacterResponseDto>(result);
            return dto;
        }

        public async Task<CharacterResponseDto> UpdateAsync(CharacterRequestDto characterRequest)
        {
            var character = _mapper.Map<Character>(characterRequest);
            var result = await _characterRepository.UpdateAsync(character);
            var dto = _mapper.Map<CharacterResponseDto>(result);
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            var character = await _characterRepository.GetByIdAsync(id);
            character.IsDeleted = true;
            await _characterRepository.UpdateAsync(character);
        }
    }
}
