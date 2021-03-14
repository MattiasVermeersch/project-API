using Imi.Project.Api.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface ICharacterService
    {
        Task<IEnumerable<CharacterResponseDto>> ListAllAsync();
        Task<CharacterResponseDto> GetByIdAsync(Guid id);
    }
}
