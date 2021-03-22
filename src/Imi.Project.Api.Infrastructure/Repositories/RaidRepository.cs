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
    public class RaidRepository : Repository<Raid>, IRaidRepository
    {
        public RaidRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        public override IQueryable<Raid> GetAllAsync()
        {
            return _dbContext.Raids.AsNoTracking()
                .Include(r => r.RaidCharacters)
                    .ThenInclude(rc => rc.Character);
        }

        public override async Task<Raid> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(r => r.Id.Equals(id));
        }

        public async Task<IEnumerable<Raid>> GetByCharacterId(Guid id)
        {
            return await GetAllAsync()
                .Where(r => r.RaidCharacters.Any(rc => rc.CharacterId.Equals(id)))
                .ToListAsync();
        }
    }
}
