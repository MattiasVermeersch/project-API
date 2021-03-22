using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface IDungeonRepository : IRepository<Dungeon>
    {
        Task<IEnumerable<Dungeon>> GetByCharacterId(Guid id);
    }
}
