using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.DataAccess.Contexts;
using Project.DataAccess.Repositories.Abstracts;
using Project.DataAccess.Repositories.Concretes;

namespace Project.DataAccess
{
    public static class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessDependencies(this  IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("SqlCon"));
            });

            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
