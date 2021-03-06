using Microsoft.Extensions.DependencyInjection;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;
using System.Linq;
using API.Errors;

namespace API.Extensions
{
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services){

        services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "SkiNet API", Version = "v1"});
            }); 

            return services;
        }

        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app){
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));

            return app;
        }
    }
}