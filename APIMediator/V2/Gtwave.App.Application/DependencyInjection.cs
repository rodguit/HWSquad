using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Gtwave.App.Application.Authentication.Common;
using Gtwave.App.Application.Authentication.Login;
using Gtwave.App.Application.Authentication.Register;
using Gtwave.App.Application.Common;
using System.Reflection;

namespace Gtwave.App.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) 
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            services.AddScoped(
                typeof(IPipelineBehavior<,>),
                typeof(ValidationBehavior<,>));

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
