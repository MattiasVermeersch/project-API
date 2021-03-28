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
    public class ArenaRepository : Repository<Arena>, IArenaRepository
    {
        public ArenaRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        public override IQueryable<Arena> GetAllAsync()
        {
            return _dbContext.Arenas.AsNoTracking()
                .Include(a => a.ArenaCharacters)
                    .ThenInclude(ac => ac.Character);
        }

        public override async Task<Arena> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(a => a.Id.Equals(id));
        }

        public async Task<IEnumerable<Arena>> GetByCharacterId(Guid id)
        {
            return await GetAllAsync()
                .Where(a => a.ArenaCharacters.Any(ac => ac.CharacterId.Equals(id)))
                .ToListAsync();
        }

        public async Task<Arena> AddCharacterAsync(Guid arenaId, Character character)
        {
            var arena = await GetByIdAsync(arenaId);

            arena.ArenaCharacters.Add(new ArenaCharacter
            {
                Arena = arena,
                Character = character
            });

            await _dbContext.SaveChangesAsync();

            return arena;
        }
    }
}
