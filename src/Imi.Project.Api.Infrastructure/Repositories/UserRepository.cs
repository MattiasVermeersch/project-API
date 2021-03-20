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
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        public override IQueryable<User> GetAllAsync()
        {
            return _dbContext.Users.AsNoTracking()
                .Include(u => u.Characters);
        }

        public override async Task<User> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(u => u.Id.Equals(id));
        }
    }
}
