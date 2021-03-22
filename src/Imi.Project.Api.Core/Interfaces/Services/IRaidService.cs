using Imi.Project.Api.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IRaidService
    {
        Task<IEnumerable<RaidResponseDto>> ListAllAsync();
        Task<RaidResponseDto> GetByIdAsync(Guid id);
        Task<IEnumerable<RaidResponseDto>> GetByCharacterId(Guid id);
    }
}
