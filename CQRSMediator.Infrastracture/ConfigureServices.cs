using CQRSMediator.Domain.Repository;
using CQRSMediator.Infrastracture.Data;
using CQRSMediator.Infrastracture.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSMediator.Infrastracture
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastractureServices(this IServiceCollection services, IConfiguration configuretion)
        {
            services.AddDbContext<ProductDbContext>(options =>
                options.UseSqlite(configuretion.GetConnectionString("ProductDbContext") ?? throw new InvalidOperationException("connection string 'ProductDbContext' not found."))
            );
            services.AddTransient<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
