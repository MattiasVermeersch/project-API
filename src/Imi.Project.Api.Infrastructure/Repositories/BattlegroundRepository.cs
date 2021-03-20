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
    public class BattlegroundRepository : Repository<Battleground>, IBattlegroundRepository
    {
        public BattlegroundRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        public override IQueryable<Battleground> GetAllAsync()
        {
            return _dbContext.Battlegrounds.AsNoTracking()
                .Include(b => b.BattlegroundCharacters)
                    .ThenInclude(bg => bg.Character);
        }

        public override async Task<Battleground> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(b => b.Id.Equals(id));
        }
    }
}
