using Microsoft.EntityFrameworkCore;
using RVO.Services.Clients.Core;
using RVO.Services.Clients.Core.Interface;
using RVO.Services.Clients.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVO.Services.Clients.Infrastructure.Data
{
    public class EfRepository : IRepository
    {
        private readonly AppDbContext _dbContext;

        public EfRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T GetById<T>(Guid id) where T : BaseEntity<Guid>, IAggregateRoot
        {
            return _dbContext.Set<T>().SingleOrDefault(e => e.Id == id);
        }

        public Task<T> GetByIdAsync<T>(Guid id) where T : BaseEntity<Guid>, IAggregateRoot
        {
            return _dbContext.Set<T>().SingleOrDefaultAsync(e => e.Id == id);
        }

        public Task<List<T>> ListAsync<T>() where T : BaseEntity<Guid>, IAggregateRoot
        {
            return _dbContext.Set<T>().ToListAsync();
        }


        public async Task<T> AddAsync<T>(T entity) where T : BaseEntity<Guid>, IAggregateRoot
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task UpdateAsync<T>(T entity) where T : BaseEntity<Guid>, IAggregateRoot
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync<T>(T entity) where T : BaseEntity<Guid>, IAggregateRoot
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
