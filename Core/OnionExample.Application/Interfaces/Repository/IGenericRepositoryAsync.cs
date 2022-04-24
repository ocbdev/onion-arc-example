using OnionExample.Domain.Entities.Common;

namespace OnionExample.Application.Interfaces.Repository;

public interface IGenericRepositoryAsync<T> where T : BaseEntity
{
    Task<T> AddAsync(T entity);
    
    Task<List<T>> GetAllAsync();

    Task<T?> GetByIdAsync(Guid id);
}