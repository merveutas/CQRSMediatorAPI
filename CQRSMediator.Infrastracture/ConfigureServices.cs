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

            return services;
        }
    }
}
