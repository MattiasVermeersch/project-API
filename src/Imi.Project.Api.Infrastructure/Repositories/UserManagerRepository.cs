﻿using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class UserManagerRepository<T> : IUserManagerRepository<T> where T : IdentityUser
    {
        protected readonly UserManager<T> _userManager;
        public UserManagerRepository(UserManager<T> userManager)
        {
            _userManager = userManager;
        }

        public virtual IQueryable<T> GetAllAsync()
        {
            return _userManager.Users.AsNoTracking();
        }

        public virtual async Task<T> GetByIdAsync(string id)
        {
            return await _userManager.FindByIdAsync(id);
        }

        public async Task<T> GetByIdAsync(string id, string[] includes)
        {
            var query = _userManager.Users.AsQueryable();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query.SingleOrDefaultAsync(t => t.Id.Equals(id));
        }

        public async Task<IEnumerable<T>> ListAllAsync()
        {
            return await GetAllAsync().ToListAsync();
        }

        public IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate)
        {
            return _userManager.Users.Where(predicate).AsQueryable();
        }

        public async Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate)
        {
            return await GetFiltered(predicate).ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _userManager.CreateAsync(entity);
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await _userManager.UpdateAsync(entity);
            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            await _userManager.DeleteAsync(entity);
            return entity;
        }

        public async Task<T> DeleteAsync(string id)
        {
            T entity = await GetByIdAsync(id);
            await DeleteAsync(entity);
            return entity;
        }
    }
}
