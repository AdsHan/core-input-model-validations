using FluentValidation.AspNetCore;
using FVO.Customer.API.Option3.Filters;
using FVO.Customer.API.Option3.Validators;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FVO.Customer.API.Option3.Configuration
{
    public static class Option3Config
    {
        public static IServiceCollection AddOption3Configuration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers(options => options.Filters.Add(typeof(FilterValidator))).ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressModelStateInvalidFilter = true; // Necessário desabilitar a validação automática do model para que o filtro valide
            })
            .AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<CustomerValidator3>());

            return services;
        }
    }
}
