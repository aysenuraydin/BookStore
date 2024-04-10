using Microsoft.Extensions.DependencyInjection;
using BookStore.Business.Abstract;
using BookStore.Business.Concrete;
using BookStore.Business.Repositories;

namespace BookStore.Business
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductCommentRepository, ProductCommentRepository>();
            services.AddScoped<IProductImageRepository, ProductImageRepository>();
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
    }
}
