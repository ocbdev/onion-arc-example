using OnionExample.Application.Interfaces.Repository;
using OnionExample.Domain.Entities;
using OnionExample.Persistence.Context;

namespace OnionExample.Persistence.Repositories;

public class ProductRepository: GenericRepositoryAsync<Product>,IProductRepository
{
  

    public ProductRepository(ApplicationDbContext dbContext): base(dbContext)
    {
        
    }
}