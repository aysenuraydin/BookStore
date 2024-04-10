using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Data;
public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BookStoreDbContext>(opt =>
        {
            //bağlantıyı güncelle
            opt.UseSqlite(configuration.GetConnectionString("DbConnection"), b => b.MigrationsAssembly("BookStore.API"));
        });

        return services;
    }

}



