using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class DungeonRepository : Repository<Dungeon>, IDungeonRepository
    {
        public DungeonRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        public override IQueryable<Dungeon> GetAllAsync()
        {
            return _dbContext.Dungeons.AsNoTracking()
                .Include(d => d.DungeonCharacters)
                    .ThenInclude(dc => dc.Character);
        }

        public override async Task<Dungeon> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(d => d.Id.Equals(id));
        }
    }
}
