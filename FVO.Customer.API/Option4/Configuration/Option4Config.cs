using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FVO.Customer.API.Option4.Configuration
{
    public static class Option4Config
    {
        public static IServiceCollection AddOption4Configuration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            return services;
        }
    }
}
