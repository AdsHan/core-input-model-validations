using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FVO.Customer.API.Option1.Configuration
{
    public static class Option1Config
    {
        public static IServiceCollection AddOption1Configuration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            return services;
        }
    }
}
