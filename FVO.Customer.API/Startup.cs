using FVO.Customer.API.Configuration;
using FVO.Customer.API.Option1.Configuration;
using FVO.Customer.API.Option2.Configuration;
using FVO.Customer.API.Option3.Configuration;
using FVO.Customer.API.Option4.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FVO.Customer.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApiConfiguration(Configuration);

            services.AddOption1Configuration(Configuration);
            //services.AddOption2Configuration(Configuration);
            //services.AddOption3Configuration(Configuration);
            //services.AddOption4Configuration(Configuration);

            services.AddSwaggerConfiguration();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseApiConfiguration(env);

            app.UseSwaggerConfiguration();
        }
    }
}
