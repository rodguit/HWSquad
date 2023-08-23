using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Gtwave.App.Api;
using Gtwave.App.Api.Common.Errors;
using Gtwave.App.Application.Authentication.Login;
using Gtwave.App.Application.Authentication.Register;
using Gtwave.App.Domain.Models.Entities;
using System.Reflection;

namespace Gtwave.App.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services) 
        {
            services.AddMappings();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(Cartorio)));
            services.AddControllers();

            services.AddSingleton<ProblemDetailsFactory, GtwaveProblemDetailsFactory>();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;

            //builder.Services.AddMediatR(typeof(Program));
            //builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            //builder.Services.AddMediatR(typeof(Gtwave.App.Domain));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

        }
    }
}
