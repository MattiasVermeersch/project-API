using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class UserRepository : UserManagerRepository<User>, IUserRepository
    {
        public UserRepository(UserManager<User> userManager) : base(userManager) { }

        public override IQueryable<User> GetAllAsync()
        {
            return _userManager.Users.AsNoTracking()
                .Include(u => u.Characters);
        }

        public override async Task<User> GetByIdAsync(string id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(u => u.Id.Equals(id));
        }
    }
}
