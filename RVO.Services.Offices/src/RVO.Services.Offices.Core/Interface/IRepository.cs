using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RVO.Services.Offices.Core.Interface
{
    public interface IRepository
    {
        Task<T> GetByIdAsync<T>(Guid id) where T : BaseEntity<Guid>, IAggregateRoot;
        Task<List<T>> ListAsync<T>() where T : BaseEntity<Guid>, IAggregateRoot; 
        Task<T> AddAsync<T>(T entity) where T : BaseEntity<Guid>, IAggregateRoot;
        Task UpdateAsync<T>(T entity) where T : BaseEntity<Guid>, IAggregateRoot;
        Task DeleteAsync<T>(T entity) where T : BaseEntity<Guid>, IAggregateRoot;
    }
}
