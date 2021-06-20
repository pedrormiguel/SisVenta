using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Common;

namespace Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T : AuditableEntity
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> ListAllAsync();

        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
