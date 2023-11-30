using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Contexts;
using Persistence.Repositories;

namespace Persistance
{
    public static class PersistanceServiceRegistration
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<BaseDbContext>(options => options.UseInMemoryDatabase("nArchitecture")); //Database ekle. 

            services.AddDbContext<BaseDbContext>(options =>
                   options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            //options => options.UseInMemoryDatabase("nArchitecture")
            services.AddScoped<IBrandRepository, BrandRepository>();
            return services;
        }

    }
}
