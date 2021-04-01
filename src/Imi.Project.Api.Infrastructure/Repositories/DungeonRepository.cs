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

        public async Task<IEnumerable<Dungeon>> GetByCharacterId(Guid id)
        {
            return await GetAllAsync()
                .Where(d => d.DungeonCharacters.Any(dc => dc.CharacterId.Equals(id)))
                .ToListAsync();
        }

        public async Task<Dungeon> AddCharacterAsync(Guid id, Character character)
        {
            var dungeon = await GetByIdAsync(id);

            dungeon.DungeonCharacters.Add(new DungeonCharacter
            {
                Dungeon = dungeon,
                Character = character
            });

            await _dbContext.SaveChangesAsync();

            return dungeon;
        }

        public async Task<Dungeon> DeleteCharacterAsync(Guid id, Character character)
        {
            var dungeon = await GetByIdAsync(id);

            dungeon.DungeonCharacters.Remove(new DungeonCharacter
            {
                Dungeon = dungeon,
                Character = character
            });

            await _dbContext.SaveChangesAsync();

            return dungeon;
        }
    }
}
