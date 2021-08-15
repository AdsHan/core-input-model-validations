using FluentValidation.AspNetCore;
using FVO.Customer.API.Option2.Validators;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FVO.Customer.API.Option2.Configuration
{
    public static class Option2Config
    {
        public static IServiceCollection AddOption2Configuration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers()
                    .AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<CustomerValidator2>());
            return services;
        }
    }
}
