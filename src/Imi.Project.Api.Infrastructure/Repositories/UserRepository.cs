using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class UserRepository : UserManagerRepository<User>, IUserRepository
    {
        public UserRepository(UserManager<User> userManager) : base(userManager) { }

        public override IQueryable<User> GetAllAsync()
        {
            return _userManager.Users
                .Include(u => u.Characters);
        }

        public override async Task<User> GetByIdAsync(string id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(u => u.Id.Equals(id));
        }

        public override async Task<User> AddAsync(User user)
        {
            var password = user.Password;

            var result = await _userManager.CreateAsync(user, password);

            if(!result.Succeeded) { 
                user.Error = result;
                await _userManager.DeleteAsync(user);
                return user; 
            }

            
            User newUser = await _userManager.FindByEmailAsync(user.Email);
            await _userManager.AddClaimAsync(newUser,
                new Claim("registration-date", DateTime.Now.ToString("yyyy-MM-dd")));

            string hasCharacters;
            if (newUser.Characters == null) hasCharacters = "false";
            else hasCharacters = "true";

            await _userManager.AddClaimAsync(newUser,
                new Claim("has-characters", hasCharacters));

            return newUser;
        }
    }
}
