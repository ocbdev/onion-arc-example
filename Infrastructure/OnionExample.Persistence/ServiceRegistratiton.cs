using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionExample.Application.Interfaces.Repository;
using OnionExample.Persistence.Context;
using OnionExample.Persistence.Repositories;

namespace OnionExample.Persistence;

public static class ServiceRegistratiton
{
    public static void AddPersistenceServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));
        serviceCollection.AddTransient<IProductRepository, ProductRepository>();
    }
}